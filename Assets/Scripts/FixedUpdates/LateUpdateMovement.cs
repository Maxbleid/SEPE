using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMovement : MonoBehaviour
{
    // Start is called before the first frame update
    private void LateUpdate()
    {
        transform.position += Vector3.up * 0.1f;
    }
}
