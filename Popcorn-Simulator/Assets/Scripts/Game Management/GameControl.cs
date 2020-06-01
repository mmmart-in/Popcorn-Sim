﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    public static GameControl gameControl;
    public int popcornCount;
    public bool[] scenariosUnlocked;

    public bool activeSession;
    
    private ScenarioControl scenarioControl;


    void Awake()
    {
        scenarioControl = FindObjectOfType<ScenarioControl>();
        Load();

        if (gameControl == null)
        {
            DontDestroyOnLoad(gameObject);
            gameControl = this;
        }
        else if (gameControl != this)
            Destroy(gameObject);

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
    }
    public void Load()
    {
        popcornCount = SaveSystem.LoadPlayer().playerCurrency;

         if (SaveSystem.LoadPlayer().scenariosUnlocked != null)
            scenariosUnlocked = SaveSystem.LoadPlayer().scenariosUnlocked;
        else
            scenariosUnlocked = new bool[] { true, false, false };

        scenarioControl.UpdateUnlocks(scenariosUnlocked);
        Debug.Log("UpdateUnlocks called with" + scenariosUnlocked);

        Debug.Log("loaded data " + SaveSystem.LoadPlayer().playerCurrency + " to gamecontrol, counter is " + popcornCount);
    }
}
