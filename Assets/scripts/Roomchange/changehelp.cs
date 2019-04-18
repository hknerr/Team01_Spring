using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//John Hangen
public class changehelp : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Help");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
