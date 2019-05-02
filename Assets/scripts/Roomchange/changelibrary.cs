using System.Collections;
using System.Collections.Generic;
// Brandon Salter
using UnityEngine;
using UnityEngine.SceneManagement;

public class changelibrary : MonoBehaviour
{
    // changes to library scene attached to library door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("library");
    }

    // Update is called once per frame
    void Update()
    {

    }
}