﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class showTextInRoom : MonoBehaviour
{
    public Text myText;
    public GameObject myGameObject;
    public int inWhichRoom;

    private void Awake()
    {
        // this script uses the buildindex of the scenes in the game - be careful with this approach
        // as moving scenes around in the list will cause problem. The nice thing is that the build index 
        // matches the roomInfo[] array elements so no calculation is needed
        int theSceneNum = SceneManager.GetActiveScene().buildIndex;

        myGameObject = GameObject.Find("Canvas/Tell the Player");
        myText = myGameObject.GetComponent<Text>();

        GameObject theGameController = GameObject.Find("GameController");
        GameControlScript controllerScript = theGameController.GetComponent<GameControlScript>();

        //set the color of the text based on the color of the room
        if (theSceneNum == 0 | theSceneNum == 1 | theSceneNum == 4 | theSceneNum == 5 | theSceneNum == 7)
        {
            myText.color = Color.white;
        }
        else
        {
            myText.color = Color.black;
        }

        myText.text = controllerScript.roomInfo[theSceneNum];
    }

}
