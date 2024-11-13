using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Game.Shared.Player.Scripts
{
    public class Animation : MonoBehaviour
    {
        private Animator anim;
        private SpriteRenderer sprite;

        private void Awake()
        {
            anim = GetComponent<Animator>();
            sprite = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (GameManager.Instance.canMove == false)
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
            }
        }

        public void SetWalkAnim(InputAction.CallbackContext value)
        {
            if (value.ReadValue<Vector2>().x != 0 && GameManager.Instance.canMove)
            {
                anim.SetBool("Walk", true);
                
                if (value.ReadValue<Vector2>().x == 1  || value.ReadValue<Vector2>().x == -1)
                {
                    anim.SetBool("Walk", true);
                    anim.SetBool("Run", true);
                }
                
                if (value.ReadValue<Vector2>().x > 0)
                {
                    sprite.flipX = false;
                }
                else if (value.ReadValue<Vector2>().x < 0)
                {
                    sprite.flipX = true;
                }
            }
            else
            {
                anim.SetBool("Walk", false);
                anim.SetBool("Run", false);
            }


        }
    }
}