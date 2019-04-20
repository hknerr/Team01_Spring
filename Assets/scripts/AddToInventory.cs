using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToInventory : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public Text myText;
    public Text newItem;
    public GameObject myGameObject;
    public GameObject invGameObj;
    public string theInventoryItem = "Inventory";
    public string numToString;
    public int addedItem;

    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();
        myGameObject = GameObject.Find("Canvas/Tell the Player");
        myText = myGameObject.GetComponent<Text>();

        if (this.tag == "I")
        {
            if (theControllerScript.InventoryList.Count < 10)
            {
                //add the item to the inventory list and determine its number in the list
                theControllerScript.InventoryList.Add(name);
                addedItem = theControllerScript.InventoryList.Count;
                Destroy(gameObject);
                //convert the number to string and form the name of the Inventory Text item in the HUD using a name
                numToString = addedItem.ToString();
                theInventoryItem += numToString;
                invGameObj = GameObject.Find("Canvas/Vertical Panel/" + theInventoryItem);
                newItem = invGameObj.GetComponent<Text>();
                newItem.text = name;
            }
            else
            {
                myText.text += "\nYou may not inventory more than 10 items - you must use an item by solving a puzzle";
            }
        }
        else
        {
            myText.text += "\nThe " + this.name + " cannot be put in inventory";
        }
    }
}
