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

    public GameObject gameOverPanel;
    public Text gameOverText;


    [Header("Timer")]
    public float gameTimer = 60;
    

    private Animator counterAnim;
    private bool timerPlayed;
    
    void Start()
    {
        gameController = this;
        timerText.text = "";
        counterAnim = cornCounterText.GetComponent<Animator>();
        gameOverPanel.SetActive(false);

    }


    void Update()
    {
        

        if (gameTimer <= 0 && gameTimer > -99)
        {
            //jävla fusklösning på hur man ska få detta kommando att sluta utföras, vi vill bara kalla detta en gång så gameTimer måste sättas till något som gör if()-statement false
            gameTimer = -100;
            TimeRanOut();

        }

        //räkna bara ned när gameTimer>0, när timern tagit slut ska inte heller cornCounterText uppdateras
        else if(gameTimer > 0)
        {
            gameTimer -= Time.deltaTime;
            cornCounterText.text = "" + cornCounterThisLevel;

            if (gameTimer < 11)
            {
                timerText.text = "" + (int)gameTimer;
                if (!timerPlayed)
                {
                    SoundManager.PlaySound("timer");
                    timerPlayed = true;
                }
            }
        }
        

    }


    public void CatchPopcorn()
    {
        counterAnim.SetTrigger("catch");
        
        cornCounterThisLevel++;
    }
    public void CatchBurntPopcorn() 
    {
        cornCounterThisLevel -= 2;
        if (cornCounterThisLevel < 0)
            cornCounterThisLevel = 0;
    }

    public void CatchGoldPopcorn()
    {
        cornCounterThisLevel += 5;
    }

    private void TimeRanOut()
    {
        gameOverPanel.SetActive(true);
        gameOverText.text = "You caught " + cornCounterThisLevel + " popcorn!";
        GameControl.gameControl.UpdatePopcornCount(cornCounterThisLevel);
        timerText.text = "";
        //SoundManager.PlaySound("gameOver");

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }




}
