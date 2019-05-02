using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the start button and beginning the process of playing the game.
public class Backtomainmenu : MonoBehaviour
{

    public void GoToMenu(string scene)
    {
        SceneManager.LoadScene("Menu");
    }

    public void ReturnToMenu(string scene)
    {
        SceneManager.LoadScene("Menu");
    }
}
