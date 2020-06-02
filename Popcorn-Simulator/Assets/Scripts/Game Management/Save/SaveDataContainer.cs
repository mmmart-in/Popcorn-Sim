using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataContainer
{
    public int currency;
    public bool [] scenariosUnlocked;

    public SaveDataContainer(int currency, bool [] scenariosUnlocked) {
        this.currency = currency;
        if(scenariosUnlocked != null)
            this.scenariosUnlocked = scenariosUnlocked;
    }
}
