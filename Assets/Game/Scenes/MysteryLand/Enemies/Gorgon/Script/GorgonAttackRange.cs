using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GorgonAttackRange : MonoBehaviour
{
    public GorgonAnimation gorgonanimation;
    public GorgonPatrol patrol;
    public CombatScript combat;
    public GameObject Gorgon;

    public GameObject pointA;
    public GameObject pointB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = pointA.transform.position;
            Gorgon.transform.position = pointB.transform.position;
            GameManager.Instance.canMove = false;
            gorgonanimation.StopWalking();
            combat.StartCombat(other.GetComponent<Status>(), Gorgon.GetComponent<Status>(), other.GetComponent<Animator>(), Gorgon.GetComponent<Animator>());
        }
    }
}
