using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{

    public int cornCounterThisLevel;
    public Text cornCounterText;

    [Header("Timer")]
    public float timer = 60;
    

    
    void Start()
    {

    }


    void Update()
    {
        cornCounterText.text = "" + cornCounterThisLevel;

        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            TimeRanOut();
        }
    }
    private void FixedUpdate()
    {
        

    }

    public void CatchPopcorn()
    {
        cornCounterThisLevel++;
    }

    private void TimeRanOut()
    {

    }


}
