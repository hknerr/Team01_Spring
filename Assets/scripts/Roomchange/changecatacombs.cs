using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Nick
public class changecatacombs : MonoBehaviour
{
    // changes door to catacombs attached to catacombs door
    private void OnMouseDown()
    {
        SceneManager.LoadScene("catacombs");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
