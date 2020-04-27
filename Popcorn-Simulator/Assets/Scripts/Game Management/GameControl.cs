using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public static GameControl gameControl;
    public int popcornCount;

    void Awake()
    {
        if (gameControl == null)
        {
            DontDestroyOnLoad(gameObject);
            gameControl = this;
        }
        else if (gameControl != this)
            Destroy(gameObject);
   
    }
        public void updatePopcornCount(int popcorn) {
        popcornCount += popcorn;
        Save();
    }

    public void Save() {
        SaveSystem.SaveData(new SaveDataContainer(popcornCount));
    }
    public void Load()
    {
        popcornCount = SaveSystem.LoadPlayer().playerCurrency;
        Debug.Log("loaded data " + SaveSystem.LoadPlayer().playerCurrency + " to gamecontrol, counter is " + popcornCount);
    }
}
