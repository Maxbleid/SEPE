using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] Rigidbody2D chasis;

    private void Awake()
    {
        if (chasis == null) throw new System.Exception("ERROR: OLVIDASTE EL CHASIS");
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            chasis.AddForce(Vector2.right*10);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            chasis.AddForce(Vector2.left*10);
        }
    }
}
