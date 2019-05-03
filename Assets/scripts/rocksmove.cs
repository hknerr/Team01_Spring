using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Christan 
//Brandon
//moves the rock in courtyard when clicked on
public class rocksmove : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameObject.Find("rocks").transform.localPosition = new Vector3(-1.9f, -4f, 0);
    }

}
