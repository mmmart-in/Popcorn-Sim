using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    void Back() {
        GameControl.gameControl.updatePopcornCount(GameController.gameController.cornCounterThisLevel);
        SceneManager.LoadScene("Main Menu");
    }
}
