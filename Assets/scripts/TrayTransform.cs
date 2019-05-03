using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//christian
//moves a tray in the diner to show a key
public class TrayTransform : MonoBehaviour
{
    private void OnMouseDown()
    {
        GameObject.Find("serving tray for room").transform.localPosition = new Vector3(-1.9f, 1.61f, 0);
    }

}
