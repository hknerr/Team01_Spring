using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryOnPress : MonoBehaviour
{
    public bool drawingGUI = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            drawingGUI = true;
    }

    void OnGUI()
    {
        if (drawingGUI)
        {
            if (Input.GetKeyDown(KeyCode.I))
                drawingGUI = false;
        }
    }
}