using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableStatue : MonoBehaviour
{
    public GameObject objToDisable;

    private void Start()
    {
        objToDisable = GameObject.Find("bath statue");
        objToDisable.transform.localPosition = new Vector2(20, 20);
    }
}
