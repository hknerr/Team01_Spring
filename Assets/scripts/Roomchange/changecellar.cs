using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Christa
// John Hangen
//This code allows the player to leave the courtyard scene and enter the diner scene.
//In the courtyard scene its attached to courtyard door object.
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
