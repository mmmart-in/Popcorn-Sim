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
    public float gameTimer = 60;
    

    private Animator counterAnim;
    
    void Start()
    {
        gameController = this;
        timerText.text = "";
        counterAnim = cornCounterText.GetComponent<Animator>();
        
        
    }


    void Update()
    {
        

        if(gameTimer < 11)
        {
            timerText.text = "" + (int)gameTimer;
        }
        
        cornCounterText.text = "" + cornCounterThisLevel;

        if(gameTimer < 11)
        {
            timerText.text = "" + (int)gameTimer;
        }
        

        gameTimer -= Time.deltaTime;
        if(gameTimer <= 0)
        {
            TimeRanOut();
        }

       
    }
    private void FixedUpdate()
    {
        

    }

    public void CatchPopcorn()
    {
        counterAnim.SetTrigger("catch");
        Debug.Log("animation");
        cornCounterThisLevel++;
    }
    public void BurntPopcorn() 
    {
        cornCounterThisLevel -= 2;
        if (cornCounterThisLevel < 0)
            cornCounterThisLevel = 0;
    }

    private void TimeRanOut()
    {
        GameControl.gameControl.UpdatePopcornCount(cornCounterThisLevel);
        SceneManager.LoadScene("Main Menu");
    }


}
