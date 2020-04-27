using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SavePlayerData
{
    public int playerCurrency = 0;


    public SavePlayerData(SaveDataContainer dataContainer) {
        playerCurrency = dataContainer.currency;

    }

}




