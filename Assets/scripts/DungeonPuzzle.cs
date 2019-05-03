using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Nicks code
/// Hunters code
/// Used for the dungeon puzzle
/// attached to a fake door that is removed
/// </summary>

public class DungeonPuzzle : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public Text myText;
    public Text newItem;
    public GameObject myGameObject;
    public GameObject invGameObj;
    
    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();

        for (int i = 0; i < 10; i++)
        {
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + (i + 1));
            newItem = invGameObj.GetComponent<Text>();
            if (newItem.text == "lockpick")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "door locked";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("nope");
            }
        }
        for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "lockpick")
            {
                theControllerScript.ItemsinInventory[i] = "";
            }
        }
    }
}
