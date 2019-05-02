using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Christa
public class changecellar : MonoBehaviour
{
    // changes to cellar attached to cellar door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("cellar");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
