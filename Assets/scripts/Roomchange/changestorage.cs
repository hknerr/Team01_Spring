using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
public class changestorage : MonoBehaviour
{
    // Changes scene to storage attached to storage door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("storage");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
