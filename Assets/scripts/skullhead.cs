using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skullhead : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Hide skull
        GameObject.Find("skullhead").transform.localScale = new Vector3(0, 0, 0);                    
    }

    // Update is called once per frame
    void Update()
    {
        // Show skull
        GameObject.Find("skullhead").transform.localScale = new Vector3(1, 1, 1);
    }
}
