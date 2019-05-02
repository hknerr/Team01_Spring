using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the help button and going to the help scene.
//It's attached to the howtoplay button on the main menu.
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
