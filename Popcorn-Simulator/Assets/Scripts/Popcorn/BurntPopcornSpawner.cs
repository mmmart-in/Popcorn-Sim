using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurntPopcornSpawner : MonoBehaviour
{
    public static BurntPopcornSpawner burntInstance;
    public float heat;
    public bool closeToFire;


    private void Start()
    {
        burntInstance = this; 
        heat = 0f;
    }
    void FixedUpdate()
    {
        if (!closeToFire && heat > 0.41)
            heat -= 0.4f * Time.fixedDeltaTime;
        else if(closeToFire && heat <= 5)
            heat += 0.2f * Time.fixedDeltaTime;       
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HeatZone"))
            closeToFire = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("HeatZone"))
            closeToFire = false;
    }
    public float getHeat() {
        return heat;
    }
}
