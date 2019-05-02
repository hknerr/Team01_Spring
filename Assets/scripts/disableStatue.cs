using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableStatue : MonoBehaviour
{
    public GameObject objToDisable;

    private void Start()
    {
        objToDisable = GameObject.Find("bathstatue");
        objToDisable.SetActive(false);
    }
}
