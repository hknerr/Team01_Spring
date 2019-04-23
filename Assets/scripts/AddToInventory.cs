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
            
            
            Destroy(gameObject);
            
            invGameObj = GameObject.Find("Canvas/Vertical Panel/" + theInventoryItem);
            newItem = invGameObj.GetComponent<Text>();
            newItem.text = name;
            
        }
        else
        {
            myText.text += "\nThe " + this.name + " cannot be put in inventory";
        }
    }
}
