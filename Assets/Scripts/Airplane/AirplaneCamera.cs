using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions;

namespace Scripts.Airplane { 

public class AirplaneCamera : MonoBehaviour
{
        [SerializeField] Transform targetTransform;
        Vector3 offset;

        private void Awake()
        {
            Assert.IsNotNull(targetTransform,"ERROR: olvidaste el target");
            offset = this.transform.position-targetTransform.position;
        }
        private void LateUpdate()
        {
            //Conservar la posicion x e y pero modificamos la z
             transform.position = new Vector3(transform.position.x,
                                  transform.position.y,
                                  targetTransform.position.z + offset.z);
        }
    }
}
