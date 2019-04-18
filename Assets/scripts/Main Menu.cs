using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
public class Start : MonoBehaviour
{

    public void LoadByIndex(int sceneIndex)

    {
        SceneManager.LoadScene(sceneIndex);
    }

}
