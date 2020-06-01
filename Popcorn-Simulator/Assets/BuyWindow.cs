using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class BuyWindow : MonoBehaviour
{
    public int result;
    private TextMeshProUGUI text;

    private void Awake()
    {
        result = 0;
        Button confirmBtn = transform.GetChild(2).gameObject.GetComponent<Button>();
        Button cancelBtn = transform.GetChild(3).gameObject.GetComponent<Button>();
    }

    public void setText(int cost) {
        text = GetComponentInChildren<TextMeshProUGUI>();
        text.text = "Would you like to spend " + cost.ToString() + " popcorn to unlock this level ?";
    }

    
    public void Confirm() {
        result =  2;
        Debug.Log("Result is " + result);
    }
    public void Cancel() {
        result =  1;
    }
}
