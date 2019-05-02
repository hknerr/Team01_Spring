using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the start button to begin the game.
//Its attached to start button on the story scene.
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
