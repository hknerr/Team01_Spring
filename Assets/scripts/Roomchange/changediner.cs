using System.Collections;
using System.Collections.Generic;
// John Hangen
//This code allows the player to leave the storage scene and enter the cellar scene.
//In the storage scene its attached to door object.
using UnityEngine;
using UnityEngine.SceneManagement;

public class changediner : MonoBehaviour
{
    // changes to diner scene attached to diner door and courtyard exit door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("diner");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
