using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stekpanna : MonoBehaviour
{
    public static Stekpanna stekpannaInstance;
    public GameController gamecontroller;
    public Transform startPosition;
    public Transform mid;
    public float distanceToFire;
    public float moveSpeed = 10;
    public float offsetY = 1;
    public bool canPop;
    public GameObject pan;
    public GameObject fire;

    private Rigidbody2D rb;


    void Start()
    {
        stekpannaInstance = this;
        canPop = false;
        //transform.position = startPosition.position;
        rb = GetComponent<Rigidbody2D>();
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
    }


    void Grab()
    {
        Touch touch = Input.GetTouch(0);
        Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position) - transform.position;
        rb.velocity = new Vector3(touchPosition.x * moveSpeed, offsetY + touchPosition.y * moveSpeed, 15);
        if (transform.position.x - touchPosition.x < 0.5f)
        {
            rb.velocity = new Vector3(0, 0, 15);
        }
        //touchPosition.z = 15;
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
            gamecontroller.CatchPopcorn();
        }
    }


}
