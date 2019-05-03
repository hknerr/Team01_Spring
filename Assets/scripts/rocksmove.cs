using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocksmove : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameObject.Find("rocks").transform.localPosition = new Vector3(-1.9f, -4f, 0);
    }

}
