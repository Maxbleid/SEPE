using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animaciones3 : MonoBehaviour
{
    [SerializeField, Range(0.1f,3f)] float timeToDestroy = 1f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(collision.gameObject,timeToDestroy);
        }
    }
}
