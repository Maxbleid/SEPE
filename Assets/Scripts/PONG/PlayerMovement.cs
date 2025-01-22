using System.Collections;
using System.Collections.Generic;
using Scripts.PONG;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace Sprite.PONG
{
    [RequireComponent(typeof(AudioSource))]
    public class PlayerMovement : MonoBehaviour
    {
        //Vector2 speedUp = new Vector2(0, 10);
        //Vector2 speedDown = new Vector2(0,-10);

        //static float paddleSpeed = 10; Si lo ponemos static,
        //el valor es el mismo para todo el que tenga el script,
        //al hacerlo de esta manera podemos poner una velocidad distinta para cada player
        [SerializeField,Range(2,15) ] float paddleSpeed =10f;
        Rigidbody2D rb;
      
        //creando Keycode de forma serialized, puedo en el editor settear que tecla es arriba y abajo 
        //para cada objecto que tenga el script asociado
        [SerializeField] KeyCode keycodeUp = KeyCode.UpArrow;
        [SerializeField] KeyCode keycodeDown = KeyCode.DownArrow;

        float maxY;

        AudioSource rebote;

        private void Awake()
        {
            rebote = GetComponent<AudioSource>();
            rb = GetComponent<Rigidbody2D>();
            Assert.IsNotNull(rb, "ERROR:falta rigidbody");
            maxY = Camera.main.orthographicSize + transform.localScale.y/2; 

            float newPositionX = Camera.main.orthographicSize *
                                Camera.main.aspect *
                                Mathf.Sign(transform.position.x) * 0.85f;
            transform.position = new Vector2(newPositionX, 0);
        }
        void FixedUpdate()
        {
            if (Input.GetKey(keycodeUp) && transform.position.y < maxY)
            {
                //rb.MovePosition(rb.position + speedUp * Time.deltaTime);
                rb.velocity = new Vector2(0,paddleSpeed);
            }
            else
            {
                if (Input.GetKey(keycodeDown) && transform.position.y > -maxY)
                {
                    rb.velocity = new Vector2(0, -paddleSpeed);
                    //rb.MovePosition(rb.position + speedDown * Time.deltaTime);
                }
                else
                {
                    rb.velocity = Vector2.zero;
                }
            }
            
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.collider.tag == Constants.BALL_TAG)
            {
                rebote.Play();
                //CASA: definir como rebota la bola con las palas
                //accedemos a la funcion ReturnBall de la pelota para no tener que acceder a su rb2D desde otro 
                //elemento como es la pala/player
                other.gameObject.GetComponent<Ball>().ReturBall(transform.position); 

            }
        }
    }
}
