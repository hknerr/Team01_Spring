using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changedungeon : MonoBehaviour
{
    // Changes to dungeon scene attached to dungeon door and story page
    private void OnMouseDown()
    {
        SceneManager.LoadScene("dungeon");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
