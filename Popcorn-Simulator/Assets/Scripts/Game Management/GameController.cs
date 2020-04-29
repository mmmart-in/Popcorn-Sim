using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController gameController;

    public int cornCounterThisLevel;
    public Text cornCounterText;
    public Text timerText;

    [Header("Timer")]
    public float timer = 60;
    

    
    void Start()
    {
        gameController = this;
        timerText.text = "";
    }


    void Update()
    {
        cornCounterText.text = "" + cornCounterThisLevel;

        if(timer < 11)
        {
            timerText.text = "" + (int)timer;
        }
        

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
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
