using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencyPopcorn : MonoBehaviour
{
    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Update()
    {
        text.text = GameControl.gameControl.popcornCount.ToString();
    }
}
