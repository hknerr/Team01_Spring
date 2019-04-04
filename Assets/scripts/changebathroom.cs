using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Hunter
public class changebathroom : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("bathroom");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
