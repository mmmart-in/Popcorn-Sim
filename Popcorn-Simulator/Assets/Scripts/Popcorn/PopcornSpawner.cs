using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornSpawner : MonoBehaviour
{
    public GameObject stekpanna;
    public GameObject popcorn;
    public GameObject burntPopcorn;

    public float xPos;
    public float yPos;

    private float popcornSpawnNumber;
    private int randomAngle;
    private float panRadius = 0.4f;

    private void FixedUpdate()
    {
        xPos = Random.Range(stekpanna.transform.position.x - panRadius, stekpanna.transform.position.x + panRadius);
        yPos = transform.position.y;
        randomAngle = Random.Range(-45, 45);

        popcornSpawnNumber = Random.Range(2, 20) * Stekpanna.stekpannaInstance.distanceToFire;
        if (popcornSpawnNumber < 3)
            if (BurntPopcornSpawner.burntInstance.getHeat() * Random.Range(1, 5) > 10)
                Instantiate(burntPopcorn, new Vector3(xPos, yPos, 14f), Quaternion.AngleAxis(randomAngle, Vector3.one));
            else
                Instantiate(popcorn, new Vector3(xPos, yPos, 14f), Quaternion.AngleAxis(randomAngle, Vector3.one));
    }



}
