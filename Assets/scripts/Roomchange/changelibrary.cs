﻿using System.Collections;
using System.Collections.Generic;
// Brandon Salter
using UnityEngine;
using UnityEngine.SceneManagement;

public class changelibrary : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        SceneManager.LoadScene("library");
    }

    // Update is called once per frame
    void Update()
    {

    }
}