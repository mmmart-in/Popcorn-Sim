using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopcornCounterDisplay : MonoBehaviour
{
    private Text display; 
    void Awake()
    {
        display = GetComponent<Text>();
        display.text = "" + GameControl.gameControl.popcornCount;
    }

}
