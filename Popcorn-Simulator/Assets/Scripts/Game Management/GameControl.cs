using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{

    public static GameControl gameControl;
    public int popcornCount;
    public bool[] scenariosUnlocked;
    


    void Awake()
    {
        if (gameControl == null)
        {
            DontDestroyOnLoad(gameObject);
            gameControl = this;
        }
        else if (gameControl != this)
            Destroy(gameObject);

        Load();
    }
       
    public void UpdatePopcornCount(int popcorn) {
        popcornCount += popcorn;
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

    /*public void CheckUnlocks(bool[] arr)
    {
        int count;
        bool[] newArray = scenariosUnlocked;

        if (popcornCount >= 100)
            count = 2;
        else if (popcornCount >= 50)
            count = 1;
        else
            count = 0;

        for (int i = 0; i <= count; i++)
        {
            newArray[i] = true;
        }
        scenariosUnlocked = newArray;
        Save();
    }*/


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

        ScenarioControl.scenarioControlInstance.UpdateUnlocks(scenariosUnlocked);

        Debug.Log("loaded data " + SaveSystem.LoadPlayer().playerCurrency + " to gamecontrol, counter is " + popcornCount);
    }
}
