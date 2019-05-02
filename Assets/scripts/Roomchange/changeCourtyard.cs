using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeCourtyard : MonoBehaviour
{
    // changes to courtyard scene attached too courtyard door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("courtyard");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
