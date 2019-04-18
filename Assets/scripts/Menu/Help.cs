using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the start button and beginning the process of playing the game.
public class Help : MonoBehaviour
{

    public void GoToHelp(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ReturnToMenu(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
