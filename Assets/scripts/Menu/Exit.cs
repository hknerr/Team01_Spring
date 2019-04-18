using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Brandon Salter
public class Exit : MonoBehaviour
{
public void hasExit()
    {
        Debug.Log("has quit game");
        Application.Quit();
    }
}
