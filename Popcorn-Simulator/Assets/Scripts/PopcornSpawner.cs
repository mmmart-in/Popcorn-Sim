using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornSpawner : MonoBehaviour
{
    public GameObject stekpanna;
    public GameObject popcorn;

    public float xPos;
    public float yPos;
    private float popcornSpawnNumber;
    private int randomAngle;

    private void FixedUpdate()
    {
        xPos = Random.Range(stekpanna.transform.position.x, stekpanna.transform.position.x + 1.304f);
        yPos = transform.position.y;
        randomAngle = Random.Range(-45, 45);
        
        popcornSpawnNumber = Random.Range(1, 10) / Stekpanna.stekpannaInstance.distanceToFire;
        if (popcornSpawnNumber > 9)
            Instantiate(popcorn, new Vector3(xPos, yPos, 0f), Quaternion.AngleAxis(randomAngle, Vector3.one));
    }


}
