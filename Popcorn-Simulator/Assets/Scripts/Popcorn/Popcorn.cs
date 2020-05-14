using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popcorn : MonoBehaviour
{
    private float upwards;
    private Rigidbody2D rb2d;
    private CircleCollider2D circle;
    private ParticleSystem particle;

    public float timerReset = 2;
    public float timer;


    void Start()
    {
        particle = GetComponentInChildren<ParticleSystem>();
        rb2d = GetComponent<Rigidbody2D>();
        circle = GetComponent<CircleCollider2D>();
        upwards = Random.Range(10, 15);
        rb2d.AddForce(new Vector2(Random.Range(-2, 2), upwards), ForceMode2D.Impulse);
        circle.enabled = false;
        //particle.Play();


    }

    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timerReset)
        {
            timer -= timer;
            circle.enabled = true;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Killzone"))
        {
            Destroy(gameObject);
            //minuspoäng appliceras här?
        }

        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
