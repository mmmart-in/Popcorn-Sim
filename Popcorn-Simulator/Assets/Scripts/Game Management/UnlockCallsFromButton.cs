using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockCallsFromButton : MonoBehaviour
{
    public BuyWindow buyWindow;
    private BuyWindow windowInstance;
    private int cost;
    private int lvlNum;
    private Coroutine coroutine;
   
    public void UnlockPark() {
        cost = 200;
        lvlNum = 1;
        if (coroutine == null)
            coroutine = StartCoroutine(PlayerChoice());
        
    }

    public void UnlockBeach() {
        cost = 300;
        lvlNum = 2;
        if(coroutine == null)
            coroutine = StartCoroutine(PlayerChoice());

    }
    public void UnlockMoon() {
        cost = 450;
        lvlNum = 3;
        StartCoroutine(PlayerChoice());
    }

    
    IEnumerator PlayerChoice()
    {

        windowInstance = Instantiate(buyWindow, FindObjectOfType<Canvas>().transform);
        windowInstance.setText(this.cost);

        while (windowInstance.result == 0)
            yield return null; 

        if (windowInstance.result == 2)
        {
            GameControl.gameControl.Purchase(cost, lvlNum);
            Debug.Log("Result 2 read in purchase call");

        }
        else if (windowInstance.result == 1)
        {
            Debug.Log("Destroyed");
        }

        Destroy(windowInstance.gameObject);
        coroutine = null;
    }
}
