using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//John Hangen
public class PauseGame : MonoBehaviour
{

    public Transform canvas;
    public Transform pauseMenu;
    public Transform soundsMenu;
    public Transform helpMenu;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        if (canvas.gameObject.activeInHierarchy == false)
        {
            if (pauseMenu.gameObject.activeInHierarchy == false)
            {
                pauseMenu.gameObject.SetActive(true);
                soundsMenu.gameObject.SetActive(false);
                helpMenu.gameObject.SetActive(false);
            }

            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;
            AudioListener.volume = 0;
        }
        else
        {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
            AudioListener.volume = 1;
        }
    }

    public void Sounds(bool Open)
    {
        if (Open)
        {
            soundsMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            soundsMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }

    public void Help(bool Open)
    {
        if (Open)
        {
            helpMenu.gameObject.SetActive(true);
            pauseMenu.gameObject.SetActive(false);
        }
        if (!Open)
        {
            helpMenu.gameObject.SetActive(false);
            pauseMenu.gameObject.SetActive(true);
        }
    }
}
