using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static GameController gameController;
    public int cornCounterThisLevel;
    public Text cornCounterText;

    void Start()
    {
        gameController = this; 
    }


    void Update()
    {
        cornCounterText.text = "" + cornCounterThisLevel;
    }


    public void CatchPopcorn()
    {
        cornCounterThisLevel++;
    }


}
