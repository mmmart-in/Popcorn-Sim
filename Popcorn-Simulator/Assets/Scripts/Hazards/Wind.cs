using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{

    private float moveSpeed = 5f;
    private float rightMove;
    private float leftMove;
    private AreaEffector2D windEffect;
    private Rigidbody2D rb;
    void Start()
    {
        SoundManager.PlaySound("Wind");
        rightMove = moveSpeed;
        leftMove -= moveSpeed;
        windEffect = GetComponent<AreaEffector2D>();
        rb = GetComponent<Rigidbody2D>();
        if(transform.position.x > Stekpanna.stekpannaInstance.transform.position.x)
        {
            rb.velocity = new Vector2(leftMove, 0);
            windEffect.forceAngle = 180;
        }
        else
        {
            rb.velocity = new Vector2(rightMove, 0);
            windEffect.forceAngle = 0;
        }
        
    }

    
    void Update()
    {
        Destroy(gameObject, 2f);
    }
}
