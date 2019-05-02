using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombclick1 : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("ribcage").transform.localPosition = new Vector3(100, 100, 0);
    }

    private void OnMouseDown()
    {
        GameObject.Find("ribcage").transform.localPosition = new Vector3(-1.83f, -0.45f, 0);

        this.GetComponent<AudioSource>().Play();
    }
}
