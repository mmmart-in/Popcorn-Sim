using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackFromScenario : MonoBehaviour
{

    public void Back() {
        GameControl.gameControl.UpdatePopcornCount(GameController.gameController.cornCounterThisLevel);
        SceneManager.LoadScene("Main Menu");
    }
}
