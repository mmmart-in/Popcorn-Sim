using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SubtractionText : MonoBehaviour
{
    private Color textColor;
    private TextMeshPro textMesh;
    private void Awake()
    {
        Destroy(gameObject, 3f);
        textMesh = GetComponent<TextMeshPro>();
        textColor = textMesh.color;
    }
    private void Update()
    {
        textColor.a -= Time.deltaTime;
        textMesh.color = textColor;
    }
}
