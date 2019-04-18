using System.Collections;
using System.Collections.Generic;
// John Hangen
using UnityEngine;
using UnityEngine.SceneManagement;

public class changediner : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("diner");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
