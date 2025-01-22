using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateMovement : MonoBehaviour
{
    void Update()
    {
        transform.position += Vector3.up*0.1f;
    }
}
