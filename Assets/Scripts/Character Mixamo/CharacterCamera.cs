using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCamera : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    Vector3 offset;
    private void Awake()
    {
        offset = this.transform.position - targetTransform.position;
    }
    private void LateUpdate()
    {
        //reescribimos el offset a coordenadas locales del target (character)
        Vector3 newOffset =
            offset.x * targetTransform.right + 
            offset.y * targetTransform.up +
            offset.z * targetTransform.forward; 
        transform.position = targetTransform.position + offset;

        transform.LookAt(targetTransform);
    }
}
