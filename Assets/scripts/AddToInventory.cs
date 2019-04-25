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
    
    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();
        

        if (this.tag == "I" & theControllerScript.invposition <10 )
        {

            theControllerScript.invposition += 1;
            Destroy(gameObject);
            theControllerScript.ItemsinInventory[theControllerScript.invposition - 1] = this.name;




            Debug.Log("invposition = " + theControllerScript.invposition);
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + theControllerScript.invposition);
            newItem = invGameObj.GetComponent<Text>();
            newItem.text = this.name;
            
        }
        else
        {
            myText.text += "\nThe " + this.name + " cannot be put in inventory";
        }
    }
}
