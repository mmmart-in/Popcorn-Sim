using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockSSB : MonoBehaviour
{
    int i = 1; 
    public void Unlock() {
        GameControl.gameControl.ToggleUnlocked(i);
    }
}
