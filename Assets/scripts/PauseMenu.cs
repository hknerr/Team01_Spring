using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
    //John Hangen
{
    public GameObject Pausemenu, PauseButton;
    //makes everything in the game pause
    public void Pause ()
    {
        Pausemenu.SetActive (true);
        PauseButton.SetActive (false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Pausemenu.SetActive (false);
        PauseButton.SetActive (true);
        Time.timeScale = 1;
    }
}
