using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{

    public GameObject credits;
    public GameObject mainMenu;
    public GameObject howToPlay;
    public GameObject scenarioChoice;

    public void PlayGame()
    {
        ChangeActiveScene(mainMenu, scenarioChoice);
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

    public void BackFromScenarioChoice()
    {
        ChangeActiveScene(scenarioChoice, mainMenu);
    }

    public void ChangeActiveScene(GameObject toTurnFalse, GameObject toTurnTrue)
    {
        toTurnFalse.SetActive(false);
        toTurnTrue.SetActive(true);
    }

}
