using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombclick : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("arm").transform.localPosition = new Vector3(100, 100, 0);
    }
    private void OnMouseDown()
    {
        GameObject.Find("arm").transform.localPosition = new Vector3(0.99f, 0.61f, 0);
        
        this.GetComponent<AudioSource>().Play();
    }
}
