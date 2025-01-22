using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


namespace Scripts.Airplane

{

public class AirplaneController : MonoBehaviour
{
        [SerializeField, Range (5f,20f), Tooltip ("Velocidad avance m/s")] float forwardSpeed = 10f;
        [SerializeField, Range(2f, 10f), Tooltip("Velocidad vertical m/s")] float verticalSpeed = 5f;
        [SerializeField, Range(5f, 20f), Tooltip("Velocidad horizontal m/s")] float horizontalSpeed = 10f;
        [SerializeField, Range(5f, 20f), Tooltip("Velocidad rotacion m/s")] float rollspeed = 90f;


        [SerializeField, Tooltip ("Mínimo valor y")] float minY= 12f;
        [SerializeField, Tooltip("Máximo valor y")] float maxY = 22f;

        [SerializeField, Tooltip("Mínimo valor X")] float minX = 100f;
        [SerializeField, Tooltip("Máximo valor X")] float maxX = 115f;


        [SerializeField, Range(20f, 180f), Tooltip("Máximo valor rotacion")] float maxRoll = 60f;

        [SerializeField, Range(0.1f,2f)] float turbulences=1f;

        [SerializeField, Range(0.5f,5f), Tooltip("margen de error en la rotacion")] float epsilon = 1f;
        
        float verticalInput;

        float horizontalInput;
        private void Update()
        {
            verticalInput = Input.GetAxisRaw(Constants.VERTICAL_AXIS);
            horizontalInput = Input.GetAxisRaw(Constants.HORIZONTAL_AXIS);

            UpdateTranslation();
            UpdateRotation();

            Debug.Log(transform.rotation.eulerAngles.z);
        }

        private void UpdateRotation()
        {
            float rotationInput = -horizontalInput;
            float eulerZ = transform.rotation.eulerAngles.z;
            if (horizontalInput == 0 && !(eulerZ <= epsilon || eulerZ >= 360 - epsilon))
            {
                rotationInput = eulerZ > 0 && eulerZ < maxRoll + epsilon ? -1 : 1;
                transform.Rotate(rotationInput * rollspeed * Time.deltaTime * Vector3.forward);
            }
            
            //creamos unos limites máximos de rotación
            if ((horizontalInput > 0 && (eulerZ <= maxRoll || eulerZ >= 360 - maxRoll + epsilon))||
                (horizontalInput < 0 && (eulerZ <= maxRoll - epsilon || eulerZ >= 360 - maxRoll)))
            {
            transform.Rotate(rotationInput * rollspeed * Time.deltaTime * Vector3.forward);

            }
        }

        private void UpdateTranslation()
        {
        
            //transform.position += Vector3.forward * Time.deltaTime*forwardSpeed;

            Vector3 verticalTranslation = Vector3.up * Time.deltaTime * verticalInput * verticalSpeed;
            Vector3 horizontalTranslation = Vector3.right * Time.deltaTime * horizontalInput * horizontalSpeed;

            Vector3 forwardTranslation = Vector3.forward * Time.deltaTime * forwardSpeed;

            Vector3 turbulenceTranslation = GetTurbulenceTranslation();

            Vector3 translation = forwardTranslation + turbulenceTranslation;

            // transform.Translate(forwardTranslation + verticalTranslation);


            //Movimiento Vertical

            if ((transform.position.y <= maxY && verticalInput > 0) ||
                (transform.position.y >= minY && verticalInput < 0))
            {
                //transform.Translate(forwardTranslation + verticalTranslation);
                translation += verticalTranslation;
            }

            //Movimiento Horizontal
            //maximo desplazamiento horizontal va desde X=100 hasta x = 115
            if ((transform.position.x <= maxX && horizontalInput > 0) ||
                (transform.position.x >= minX && horizontalInput < 0))
            {
                //transform.Translate(forwardTranslation + verticalTranslation);
                translation += horizontalTranslation;
            }
            //debemos realizar ls rotaciones usando espacio global no local
            //transform.Translate(translation);
            transform.Translate(translation, Space.World);
        }

        private Vector3 GetTurbulenceTranslation()
        {
            float minRange = transform.position.y <= maxY ? +turbulences : 0f;
            float maxRange = transform.position.y >= minY ? -turbulences : 0f;
            return Random.Range(minRange,maxRange) * Vector3.up * Time.deltaTime;
        }

        private void OnGUI()
        {
            GUIStyle style = new GUIStyle();
            style.fontSize = 48;
            GUI.Label(new Rect(10, 0, 150f, 150f), "Euler Z:  " +transform.rotation.eulerAngles.z, style);
        }
    }

}
