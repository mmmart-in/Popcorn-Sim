using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubtractionText : MonoBehaviour
{
    private Color textColor;
    private Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        textColor = text.color;
        textColor.a -= Time.deltaTime;
    }
    private void Update()
    {
        text.color = textColor;
    }
}
