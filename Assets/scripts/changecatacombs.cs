using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Nick
public class changecatacombs : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("catacombs");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
