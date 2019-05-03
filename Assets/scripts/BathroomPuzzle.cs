﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Hunters code
/// Used to drain the tub and get the statue within the tub
/// attached to tub
/// </summary>
public class BathroomPuzzle : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public Text myText;
    public Text newItem;
    public GameObject myGameObject;
    public GameObject invGameObj;
    public GameObject itemToDelete;
    public GameObject theStatue;
   

    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();


        for (int i = 0; i < 10; i++)
        {
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + (i + 1));
            newItem = invGameObj.GetComponent<Text>();
            if (newItem.text == "wrench")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "wrench";

                itemToDelete = GameObject.Find("bathtub");
                GameObject.Destroy(itemToDelete);


                theStatue = GameObject.Find("Statue 2");
                theStatue.transform.localPosition = new Vector2(1.75f, 1.4f);

            }

            else
            {
                Debug.Log("NO WRENCH");
            }
            
        }
        for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "wrench")
            {
                theControllerScript.ItemsinInventory[i] = "";
            }
        }

    }
}
