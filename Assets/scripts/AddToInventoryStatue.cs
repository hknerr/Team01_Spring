using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddToInventoryStatue : MonoBehaviour
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


            theControllerScript.statueinvposition += 1;
            
            theControllerScript.deletePosition += 1;
            theControllerScript.StatuesInInventory[theControllerScript.statueinvposition - 1] = this.name;
            theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = this.name;



            invGameObj = GameObject.Find("Statue Inv/Vertical Panel/InventoryText");
            newItem = invGameObj.GetComponent<Text>();
            newItem.text = this.name;

        Destroy(gameObject);


    }
}
