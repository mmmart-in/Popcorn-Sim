using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornSpawner : MonoBehaviour
{
    public static PopcornSpawner popcornSpawnerInstance;

    public GameObject stekpanna;
    public GameObject [] popcorn;
    public GameObject burntPopcorn;
    public CameraShake cameraShake;
    public GameObject goldPopcorn;
    

    public float xPos;
    public float yPos;

    private float popcornSpawnNumber;
    private int randomAngle;
    private float panRadius = 0.4f;

    private void Awake()
    {
        popcornSpawnerInstance = this; 
    }
    private void FixedUpdate()
    {
        xPos = Random.Range(stekpanna.transform.position.x - panRadius, stekpanna.transform.position.x + panRadius);
        yPos = transform.position.y;
        randomAngle = Random.Range(-45, 45);

        
        popcornSpawnNumber = Random.Range(2, 20) * Stekpanna.stekpannaInstance.distanceToFire;

        popcornSpawnNumber = Random.Range(2, 20) * Stekpanna.stekpannaInstance.distanceToFire;
        if (popcornSpawnNumber < 3)
            if (BurntPopcornSpawner.burntInstance.getHeat() * Random.Range(3, 5) > 10)
            {
                SoundManager.PlaySound("burnedPopcorn");
                StartCoroutine(cameraShake.Shake(.15f, .025f));
                Instantiate(burntPopcorn, new Vector3(xPos, yPos, 14f), Quaternion.AngleAxis(randomAngle, Vector3.one));
            }

            else
            {
                SoundManager.PlaySound("popcorn");
                Instantiate(popcorn[Random.Range(0, 6)], new Vector3(xPos, yPos, 14f), Quaternion.AngleAxis(randomAngle, Vector3.one));
            }
                

    }

    public void InstantiateGoldPopcorn() {
        Instantiate(goldPopcorn, new Vector3(xPos, yPos, 14f), Quaternion.AngleAxis(randomAngle, Vector3.one));
    }


}
