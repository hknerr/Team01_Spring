using System.Collections;
using System.Collections.Generic;
// Brandon Salter
using UnityEngine;
using UnityEngine.SceneManagement;

public class changebedroom : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("bedroom");
    }

    // Update is called once per frame
    void Update()
    {

    }
}