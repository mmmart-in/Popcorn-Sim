using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl gameControl;
    public int popcornCount;
    public bool[] scenariosUnlocked;

    
    private ScenarioControl scenarioControl;


    void Awake()
    {
        Load();
        if (gameControl == null)
        {
            DontDestroyOnLoad(gameObject);
            gameControl = this;
        }
        else if (gameControl != this)
            Destroy(gameObject);

    }
   
    public void PopcornPlease() {
        UpdatePopcornCount(150);
    }
    public void UpdatePopcornCount(int popcorn) {
        popcornCount += popcorn;
        Save();
    }
    public void UpdatePopcornCount() {
        popcornCount += GameController.gameController.cornCounterThisLevel;
        Save();
    }
    public void Purchase(int cost, int levelNumber)
    {
        if (popcornCount < cost)
        {
            Debug.Log("cant afford item");
        }

        else
        {
            popcornCount -= cost;
            scenariosUnlocked[levelNumber] = true;
            Save();
            Load();
        }
    }



    public void Save() {
        SaveSystem.SaveData(new SaveDataContainer(popcornCount, scenariosUnlocked));
        Debug.Log("Saved");
    }
    public void Load()
    {
        Debug.Log("Loaded");
        popcornCount = SaveSystem.LoadPlayer().playerCurrency;

        GetScenariosUnlocked();

        Debug.Log("loaded data " + SaveSystem.LoadPlayer().playerCurrency + " to gamecontrol, counter is " + popcornCount);

        scenarioControl.UpdateUnlocks(scenariosUnlocked);
        Debug.Log("UpdateUnlocks called with" + scenariosUnlocked);


    }

    private void GetScenariosUnlocked() {
        scenarioControl = FindObjectOfType<ScenarioControl>();

        if (SaveSystem.LoadPlayer().scenariosUnlocked == null || SaveSystem.LoadPlayer().scenariosUnlocked.Length != ScenarioControl.scenarioControlInstance.scenarios.Length)
            scenariosUnlocked = new bool[] { true, false, false, false };       
        else
            scenariosUnlocked = SaveSystem.LoadPlayer().scenariosUnlocked;

    }
}
