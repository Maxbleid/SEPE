using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Rand = UnityEngine.Random;


namespace Scripts.PONG
{
    public class Ball : MonoBehaviour
    {
        Rigidbody2D rigidb2D;
        [SerializeField] float speed = 10f;
        private void Awake()
        {
            rigidb2D = GetComponent<Rigidbody2D>();

            Assert.IsNotNull(rigidb2D, "ERROR:falta rigidbody");
            Reset();
        }

        internal void Reset()
        {
            ResetPosition();
            ResetVelocity();
        }

        private void ResetPosition()
        {
            float randomY = Random.Range(-0.25f,0.25f) * Camera.main.orthographicSize;
            transform.position = new Vector2 (0, randomY);  
        }
        private void ResetVelocity()
        {
            float randomX = Rand.Range(5f,10f);
            float randomY = Rand.Range(-5f,5f);

            // con el normalize convierto el vector en unitario pero con la direccion aleatoria
            // y multiplicamos por 10 para la magnitud de ese vector
            if (rigidb2D.velocity.x > 0)
            {
                rigidb2D.velocity = new Vector2(-randomX, randomY).normalized * speed;
            }
            else
            { 
            rigidb2D.velocity = new Vector2(randomX, randomY).normalized * speed;
            }
        }

        public void ReturBall(Vector3 paddlePosition)
        {
            Vector3 ballPosition = transform.position;
            rigidb2D.velocity =
                   (ballPosition - paddlePosition).normalized * speed;        
        }
    }
}

