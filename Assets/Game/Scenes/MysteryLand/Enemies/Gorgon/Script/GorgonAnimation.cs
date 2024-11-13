using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorgonAnimation : MonoBehaviour
{
    private Animator anim;
    private SpriteRenderer sprite;
    void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WalkingRight()
    {
        anim.SetBool("Run", true);
        GorgonFlip();
    }
    public void WalkingLeft()
    {
        anim.SetBool("Run", true);
        GorgonFlip();
    }

    private void GorgonFlip()
    {
        sprite.flipX = !sprite.flipX;
    }

    public void StopWalking()
    {
        anim.SetBool("Run", false);
    }

    public void Attack()
    {
        anim.SetTrigger("Attack");
    }
}
