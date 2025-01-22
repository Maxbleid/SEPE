using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneBlendTreeAnimationController : MonoBehaviour
{
    [SerializeField, Range(0f,5f)] float walkingSpeed;
    [SerializeField, Range(0f, 5f)] float runningSpeed;
    [SerializeField, Range(0f, 5f)] float rotationSpeed;

    Animator animator;
    float verticalInput;
    float horizontalInput;
    Rigidbody rigid;
    private void FixedUpdate()
    {
        
    }
    private void UpdateRigidbody()
    {
        float speed = IsWalking() && IsRunning() ? runningSpeed : IsWalking() ? walkingSpeed : 0f;
        if (verticalInput > 0)
        {
            rigid.velocity = transform.forward * verticalInput * speed;
            rigid.angularVelocity = Vector3.up * horizontalInput * rotationSpeed * Mathf.Deg2Rad;
        }
        else
        {
            rigid.velocity = Vector3.zero;
            rigid.angularVelocity = Vector3.zero;
        }
    }

    private void UpdateAnimation()
    {
        animator.SetFloat("Speed", verticalInput);   
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
