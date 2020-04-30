using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameControl : MonoBehaviour
{
    public static GameControl gameControl;
    public int popcornCount;
    public GameObject[] scenarios;
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
       
    public void updatePopcornCount(int popcorn) {
        popcornCount += popcorn;
        Save();
    }

    public void Unlock(int scenarioNum) {
        scenariosUnlocked[scenarioNum] = true;
        Debug.Log(scenariosUnlocked[1]);
        Save();
        Load();
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

        for (int i = 0; i < scenarios.Length; i++ ) {
            scenarios[i].GetComponent<Button>().interactable = scenariosUnlocked[i];
            scenarios[i].transform.GetChild(0).GetComponent<Image>().enabled = !scenariosUnlocked[i];
            }

        Debug.Log("loaded data " + SaveSystem.LoadPlayer().playerCurrency + " to gamecontrol, counter is " + popcornCount);
    }
}
