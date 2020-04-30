using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpawner : MonoBehaviour
{

    public Transform[] windPoints;
    public GameObject wind;

    private CircleCollider2D circle;
    //timerReset ska vara private
    
    public float timerResetMin = 2f;
    public float timerResetMax = 7f;
    public float timerReset;
    public float timer;
    void Start()
    {
        circle = GetComponent<CircleCollider2D>();
        
    }

    
    void Update()
    {
        timerReset = Random.Range(timerResetMin, timerResetMax);
        timer += Time.deltaTime;

        int randomWindPoint = Random.Range(0, windPoints.Length);
        if(timer >= timerReset)
        {
            timer -= timer;
            Instantiate(wind, windPoints[randomWindPoint]);
            
        }

    }
}
