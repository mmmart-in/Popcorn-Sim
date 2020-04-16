using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stekpanna : MonoBehaviour
{
    public Transform startPosition;
    public Transform mid;
    public float distanceToFire;
    public bool canPop;
    public GameObject pan;
    public GameObject fire;

    private float panAdjustRightHand = 1f;
    private float panAdjustLeftHand = 1f;
    private SpriteRenderer sr;
    private Rigidbody2D rb;

    void Start()
    {
        canPop = false;
        transform.position = startPosition.position;
        sr = GetComponent<SpriteRenderer>();
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
        if(Input.touchCount == 0)
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
        if (Camera.main.ScreenToWorldPoint(touch.position).x >= mid.position.x)
        {
            sr.flipX = false;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = new Vector3(touchPosition.x - panAdjustRightHand, touchPosition.y);
            touchPosition.z = 15;
        }
        else if (Camera.main.ScreenToWorldPoint(touch.position).x < mid.position.x)
        {
            
            sr.flipX = true;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            transform.position = new Vector3(touchPosition.x + panAdjustLeftHand, touchPosition.y);
            touchPosition.z = 15;

        }
    }

    void GrabWithMouse()
    {
        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x >= mid.position.x)
        {
            sr.flipX = false;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(touchPosition.x - panAdjustRightHand, touchPosition.y);
            touchPosition.z = 15;
        }
        else if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < mid.position.x)
        {

            sr.flipX = true;
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(touchPosition.x + panAdjustLeftHand, touchPosition.y);
            touchPosition.z = 15;

        }
    }
}
