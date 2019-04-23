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
    public int invposition = 0;

    private void OnMouseDown()
    {
        //theGameController = GameObject.Find("GameController");
        //theControllerScript = theGameController.GetComponent<GameControlScript>();
        

        if (this.tag == "I")
        {
            
            
            Destroy(gameObject);

            invposition += 1;
            Debug.Log("invposition = " + invposition);
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + invposition);
            newItem = invGameObj.GetComponent<Text>();
            newItem.text = this.name;
            
        }
        else
        {
            myText.text += "\nThe " + this.name + " cannot be put in inventory";
        }
    }
}
