using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCallsFromButton : MonoBehaviour
{
    public void UnlockPark() {
        GameControl.gameControl.Purchase(200, 1);
    }

    public void UnlockBeach() {
        GameControl.gameControl.Purchase(300, 2);
    }
    public void Hey() { Debug.Log("Hey"); }
}
