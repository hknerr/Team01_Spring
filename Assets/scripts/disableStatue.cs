using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableStatue : MonoBehaviour
{
    public GameObject objToDisable;

    private void Start()
    {
        objToDisable = GameObject.Find("Statue 2");
        objToDisable.transform.localPosition = new Vector2(20, 20);
    }
}
