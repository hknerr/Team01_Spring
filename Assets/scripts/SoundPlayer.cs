using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Brandon Salter
public class SoundPlayer : MonoBehaviour
{
    // Creative idea, on mouse click plays an audio source
    private void OnMouseDown()
    {
        this.GetComponent<AudioSource>().Play();
    }

}
