using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{

    public int cornCounterThisLevel;
    public Text cornCounterText;

    /*public GameObject eld;
    public GameObject popcorn;
    public GameObject stekpanna;

    public float distance;
    private float randomAngle;
    private float popcornSpawnNumber;*/
    void Start()
    {

    }


    void Update()
    {
        cornCounterText.text = "" + cornCounterThisLevel;

        /*distance = Vector3.Distance(stekpanna.transform.position, eld.transform.position);

        randomAngle = Random.Range(-45, 45);

        if (Input.GetKeyDown(KeyCode.B))
            Instantiate(popcorn, new Vector3(PopcornSpawner.popcornSpawnerInstance.xPos, PopcornSpawner.popcornSpawnerInstance.yPos, 0f), Quaternion.AngleAxis(randomAngle, Vector3.one));*/


    }
    private void FixedUpdate()
    {
        /*popcornSpawnNumber = Random.Range(1, 10) / distance;
        if(popcornSpawnNumber > 9)
            Instantiate(popcorn, new Vector3(PopcornSpawner.popcornSpawnerInstance.xPos, PopcornSpawner.popcornSpawnerInstance.yPos, 0f), Quaternion.AngleAxis(randomAngle, Vector3.one));*/

    }

    public void CatchPopcorn()
    {
        cornCounterThisLevel++;
    }


}
