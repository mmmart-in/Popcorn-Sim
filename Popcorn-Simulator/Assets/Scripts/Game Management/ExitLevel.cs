using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitLevel : MonoBehaviour
{
    public void ExitToMainMenu() {
        GameControl.gameControl.UpdatePopcornCount(GameController.gameController.cornCounterThisLevel);
        SceneManager.LoadScene("Main Menu");
    }
}
