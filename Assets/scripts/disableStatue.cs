using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableStatue : MonoBehaviour
{
    public GameObject objToDisable;
    public bool disabled = true;
    void Start()
    {
        objToDisable.SetActive = (disabled);
    }

}
