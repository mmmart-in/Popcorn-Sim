using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public GameObject credits;
    public GameObject mainMenu;
    public GameObject howToPlay;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HowToPlay()
    {
        ChangeActiveScene(mainMenu, howToPlay);
    }

    public void Credits()
    {
        ChangeActiveScene(mainMenu, credits);
    }

    public void BackFromCredits()
    {
        ChangeActiveScene(credits, mainMenu);
    }

    public void ChangeActiveScene(GameObject toTurnFalse, GameObject toTurnTrue)
    {
        toTurnFalse.SetActive(false);
        toTurnTrue.SetActive(true);
    }

}
