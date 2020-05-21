using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]  private Transform dmgPopUp;

    void Start()
    {
        Instantiate(dmgPopUp, Vector3.zero, Quaternion.identity);    
    }


}
