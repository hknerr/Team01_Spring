using System.Collections;
using System.Collections.Generic;
// John Hangen
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
