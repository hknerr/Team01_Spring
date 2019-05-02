using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Nick
public class tombclick2 : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("leg").transform.localPosition = new Vector3(100, 100, 0);
    }
        private void OnMouseDown()
    {
        GameObject.Find("leg").transform.localPosition = new Vector3(-0.51f, -0.06f, 0);

        this.GetComponent<AudioSource>().Play();
    }
}
