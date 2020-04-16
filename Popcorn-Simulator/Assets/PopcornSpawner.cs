using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopcornSpawner : MonoBehaviour
{
    public static PopcornSpawner popcornSpawnerInstance;
    public GameObject stekpanna;

    public int minSpawnTime;
    public int maxSpawnTime;

    public float xPos;
    public float yPos;

    void Start()
    {
        popcornSpawnerInstance = this;
    }


    void Update()
    {
        xPos = Random.Range(stekpanna.transform.position.x, stekpanna.transform.position.x + 1.304f);
        yPos = transform.position.y;
    }

}
