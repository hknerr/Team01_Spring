using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//christian
//unlocks the kitchen door
//attached to kitchen door in cellar
public class KitchenLock : MonoBehaviour
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
            if (newItem.text == "gold key")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = null;
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "kitchen door locked";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("nope");
            }
        }
            for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "gold key")
            {
                theControllerScript.ItemsinInventory[i] = null;
            }
        }
    }
}