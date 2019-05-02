using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Brandon Salter
public class SoundPlayer : MonoBehaviour
{
    // Creative idea, on mouse click plays an audio source
    //Plays a sound when clicking on an object; Attached to: Iowa, Bird; Fireplace and Jiggle billy.
    private void OnMouseDown()
    {
        this.GetComponent<AudioSource>().Play();
    }

}
