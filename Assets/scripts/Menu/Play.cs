using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{

    public void GoToStory(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ReturnToMenu(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
