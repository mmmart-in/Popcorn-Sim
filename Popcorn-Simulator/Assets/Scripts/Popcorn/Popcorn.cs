using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcorn : MonoBehaviour
{   
    private float upwardsForce;
    private Rigidbody2D rb2d;
    

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        upwardsForce = Random.Range(10, 15);
        rb2d.AddForce(new Vector2(Random.Range(-2, 2), upwardsForce), ForceMode2D.Impulse);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Killzone"))
            Destroy(gameObject);
        if (other.CompareTag("Player"))
        {
         
            Destroy(gameObject);
        }
    }

}
