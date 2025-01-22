using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


namespace Scripts.PONG
{
    [RequireComponent(typeof(AudioSource))]
    public class LimiteSuperiorInferior : MonoBehaviour
    {
        float cameraWidth;
        [SerializeField] Camera cam;
        AudioSource rebote;
        private void Awake()
        {
            rebote = GetComponent<AudioSource>();
            rebote.playOnAwake = false;
            float positionY = cam.orthographicSize + this.transform.localScale.y / 2;
            cameraWidth = 2f * cam.orthographicSize * cam.aspect;
            this.transform.localScale = new Vector3(cameraWidth, this.transform.localScale.y, this.transform.localScale.z);
            if ( this.tag == Constants.LIMITESUPERIOR_TAG)
            {
                this.transform.position =
                    new Vector3(0, positionY, 0);
            }
            if (this.tag == Constants.LIMITEINFERIOR_TAG)
            {
                this.transform.position =
                    new Vector3(0, -positionY, 0);
            }
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == Constants.BALL_TAG)
            {
                rebote.Play();
                Debug.Log("rebote");
            }
        }
    }

}
