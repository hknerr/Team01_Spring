using System.Collections;
using System.Collections.Generic;
// Brandon Salter
using UnityEngine;
using UnityEngine.SceneManagement;

public class changebedroom : MonoBehaviour
{
    // changes to bedroom attached to bedroom door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("bedroom");
    }

    // Update is called once per frame
    void Update()
    {

    }
}