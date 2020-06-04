using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioChoice : MonoBehaviour
{
    public void BackToScenarioChoice() {
        
        GameControl.gameControl.UpdatePopcornCount();
        SceneManager.LoadScene("ScenarioChoice");
    }
    public void BackToMainMenu() {
        SceneManager.LoadScene("Main Menu");
    }
    public void HomeSweetHome()
    {
        SceneManager.LoadScene("Kitchen");
    }

    public void SweetSummerBreeze()
    {
        SceneManager.LoadScene("PARK");
    }

    public void BeachesBeBitchin()
    {
        SceneManager.LoadScene("Beach");
    }

    public void LunarLovingLunatic() {
        SceneManager.LoadScene("Moon");
    }
}
