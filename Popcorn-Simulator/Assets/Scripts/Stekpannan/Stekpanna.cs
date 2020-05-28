﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stekpanna : MonoBehaviour
{
    public static Stekpanna stekpannaInstance;
    public GameController gamecontroller;
    public Transform startPosition;
    public Transform mid;
    public GameObject pan;
    public GameObject fire;
    

    public float distanceToFire;
    public float moveSpeed = 10;
    public float offsetY = 1;
    public bool canPop;

    public List<GameObject> pops = new List<GameObject>();
    public AudioClip[] catchSounds;

    public Transform subtractionText;
    private Rigidbody2D rb;
    private AudioSource audSrc;
    private ParticleSystem particle;

    public int lastCatch;
    private float catchTimer;
    private float timerLength = 1.5f;



    void Start()
    {
        stekpannaInstance = this;
        canPop = false;
        //transform.position = startPosition.position;
        rb = GetComponent<Rigidbody2D>();
        audSrc = GetComponent<AudioSource>();
        particle = GetComponent<ParticleSystem>();

        catchTimer = timerLength;

    }


    void Update()
    {
        if (Input.touchCount > 0)
        {
            Grab();
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        if (Input.touchCount == 0)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        if (Input.GetMouseButton(0))
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            GrabWithMouse();
        }
        distanceToFire = Vector3.Distance(pan.transform.position, fire.transform.position);


        if (catchTimer <= 0 && pops.Count == lastCatch)
        {
            pops.Clear();
            catchTimer = timerLength;
            lastCatch = 0;


        }

        if (pops.Count > 0)
        {
            catchTimer -= Time.deltaTime;
        }

        if(gamecontroller.gameTimer <= 0)
        {
            this.gameObject.SetActive(false);
        }


    }


    void Grab()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        rb.velocity = new Vector3(touchPosition.x * moveSpeed, offsetY + touchPosition.y * moveSpeed, 15);
        if (transform.position.x - touchPosition.x < 0.5f || transform.position.y - touchPosition.y < 0.5f)
        {
            rb.velocity = new Vector3(0, 0, 15);
        }

    }

    void GrabWithMouse()
    {
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        rb.velocity = new Vector3(touchPosition.x * moveSpeed, offsetY + touchPosition.y * moveSpeed, 15);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Popcorn"))
        {

            //Add popcorn to pops
            pops.Add(collision.gameObject);



            //Reset Timer
            catchTimer = timerLength;

            //Play correct sound
            if (lastCatch < 7)
            {
                AudioClip clipToPlay = catchSounds[lastCatch];
                audSrc.PlayOneShot(clipToPlay, 0.6f);
                lastCatch++;
            }
            else if(lastCatch == 7)
            {
                particle.Play(true);
                SoundManager.PlaySound("yay");
                PopcornSpawner.popcornSpawnerInstance.InstantiateGoldPopcorn();
                lastCatch = 0;
                pops.Clear();
                //tvungen att ha med pop.clear() här men vad gör pops? fattar fasen inte
            }
            gamecontroller.CatchPopcorn();
        }

        if (collision.CompareTag("BurntPopcorn"))
        {
            Instantiate(subtractionText, (collision.transform.localPosition), Quaternion.identity);
            gamecontroller.CatchBurntPopcorn();
            SoundManager.PlaySound("burntCatch");
            lastCatch = 0;
            pops.Clear();
        }
        if (collision.CompareTag("GoldPopcorn"))
        {
            gamecontroller.CatchGoldPopcorn();
            //SoundManager.PlaySound("");
        }
    }


}
