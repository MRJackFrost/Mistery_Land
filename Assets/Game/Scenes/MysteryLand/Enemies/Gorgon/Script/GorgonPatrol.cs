using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GorgonPatrol : MonoBehaviour
{
    [SerializeField]private GameObject pointA;
    [SerializeField]private GameObject pointB;
    private Rigidbody2D rb;
    public GorgonAnimation gorgonanimation;
    

    private Transform point;
    [SerializeField]private float speed;
    // Start is called before the first frame update
    void Start()
    {
        GorgonGetSet();
    }

   

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance.canMove)
        {
            GorgonPatrolUpdate();
        }
        
    }
    
    private void GorgonGetSet()
    {
        rb = GetComponent<Rigidbody2D>();
        point = pointB.transform;
    }

    private void GorgonPatrolUpdate()
    {
        Vector2 newpoint = point.position - transform.position;
        if (point == pointB.transform)
        {
            rb.velocity = new Vector2(speed, 0);
            
        }
        else
        {
            rb.velocity = new Vector2(-speed, 0);
            
        }

        if (Vector2.Distance(transform.position, point.position) < 0.5f && point == pointB.transform)
        {
            gorgonanimation.WalkingRight();
            point = pointA.transform;
        }
        if (Vector2.Distance(transform.position, point.position) < 0.5f && point == pointA.transform)
        {
            gorgonanimation.WalkingLeft();
            point = pointB.transform;
        }
    }
    
    
}
