using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NoBlendTreeAnimatorController : MonoBehaviour
{
    Animator animator;
    float verticalInput;
    [SerializeField,Range(0.5f,10f)] float walkingSpeed=4;
    [SerializeField, Range(0.5f, 10f)] float runningSpeed = 8;
    Rigidbody rb;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        verticalInput = Mathf.Clamp(Input.GetAxis("Vertical"),0,0.05f);
        //if(verticalInput == 1)
        //{
        //    animator.SetBool("IsWalking", true);
        //}
        //else
        //{
        //    animator.SetBool("IsWalking", false);
        //}
        float speed = IsWalking() && IsRunning() ? runningSpeed : IsWalking()?walkingSpeed : 0;
        rb.velocity = Vector3.forward * verticalInput * speed;

        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        animator.SetBool("IsWalking", IsWalking());
        animator.SetBool("IsRunning", IsWalking() && IsRunning());
    }

    private bool IsRunning()
    {
        return Input.GetKey(KeyCode.LeftShift);
    }

    private bool IsWalking()
    {
        return verticalInput > 0.05f;
    }
}
