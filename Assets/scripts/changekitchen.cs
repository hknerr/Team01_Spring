using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Chris
public class changekitchen : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("kitchen");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
