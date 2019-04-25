using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleui : MonoBehaviour
{
    public bool enableUI = true;
    void update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            enableUI = !enableUI;
            this.enabled = enableUI;
            Debug.Log("I pressed");
        }
    }
}
