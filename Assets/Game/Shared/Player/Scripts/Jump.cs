using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Shared.Player.Scripts
{
public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool CanJump;
    private Animator anim;

    [SerializeField] private int jumpForce;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    public void SetJump(InputAction.CallbackContext value)
    {
        if (CanJump)
        {
            rb.AddForce(Vector2.up * jumpForce);
            CanJump = false;
            anim.SetBool("Jump", true);
        }
        
    }

    public void JumpButton()
    {
        if (CanJump)
        {
        rb.AddForce(Vector2.up * jumpForce);
        CanJump = false;
        anim.SetBool("Jump", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Ground"))
        {
            CanJump = true;
            anim.SetBool("Jump", false);
        }
    }
}
}   
