using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Shared.Player.Scripts
{
   
    public class Walk : MonoBehaviour
    {
        private Vector2 moviment;
        private Rigidbody2D rb;
        private bool CanJump;
        private int jumpForce = 5000;
        private Animator anim;

        [SerializeField] private int speed;
        // Start is called before the first frame update
        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
            GameManager.Instance.canMove = true;
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void SetMoviment(InputAction.CallbackContext value)
        {
            
                moviment = value.ReadValue<Vector2>();
            
        }

        private void FixedUpdate()
        {
            if (GameManager.Instance.canMove)
            {
                if (moviment.y > 0)
                {
                    if (CanJump && moviment.y > 0.5f) 
                    {
                        rb.AddForce(Vector2.up * jumpForce);
                        CanJump = false;
                        anim.SetBool("Jump", true);
                    }

                    moviment.y = 0;

                }
                rb.AddForce(new Vector2(moviment.x,moviment.y) * speed);
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
