using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the start button and beginning the process of playing the game.
//Its attached to start button on the main menu.
public class Play : MonoBehaviour
{

    public void GoToStory(string scene)
    {
        SceneManager.LoadScene("story");
    }

    public void ReturnToMenu(string scene)
    {
        SceneManager.LoadScene("story");
    }
}
