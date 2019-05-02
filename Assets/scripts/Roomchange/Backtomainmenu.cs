using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
//This is the code for clicking on the main menu button on the help scene and going back to the main menu.
//It's attached to the Menu Button on the help scene.
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
