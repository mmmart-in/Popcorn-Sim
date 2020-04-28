using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioChoice : MonoBehaviour
{
    public void HomeSweetHome()
    {
        SceneManager.LoadScene(1);
    }

    public void SweetSummerBreeze()
    {
        SceneManager.LoadScene(2);
    }

    public void BeachesBeBitchin()
    {
        SceneManager.LoadScene(3);
    }
}
