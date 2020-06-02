using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioControl : MonoBehaviour
{
    public static ScenarioControl scenarioControlInstance;
    public GameObject [] scenarios;

    public void Awake()
    {       
            scenarioControlInstance = this;
    }
    public void UpdateUnlocks(bool[] scenariosUnlocked)
    {
        for(int i = 0; i < scenariosUnlocked.Length; i ++)
            Debug.Log(scenariosUnlocked[i]);


        for (int i = 0; i < scenarios.Length; i++)
        {
                scenarios[i].GetComponent<Button>().interactable = scenariosUnlocked[i];
                scenarios[i].transform.GetChild(0).GetComponent<Image>().enabled = !scenariosUnlocked[i];
                scenarios[i].transform.GetChild(1).GetComponent<Image>().enabled = !scenariosUnlocked[i];
        }
    }
}
