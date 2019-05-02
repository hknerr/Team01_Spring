using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Brandon Salter
//this script is used to complete the statue puzzle in the bedroom
public class Bedroompuzzle : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public Text myText;
    public Text newItem;
    public GameObject myGameObject;
    public GameObject invGameObj;
    public GameObject itemToDelete;


    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();

        for (int i = 0; i < 10; i++)
        {
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + (i + 1));
            newItem = invGameObj.GetComponent<Text>();
            if (newItem.text == "screw driver")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "screw driver";

                itemToDelete = GameObject.Find("Statue 3");
                GameObject.Destroy(itemToDelete);
            }


            else
            {
                Debug.Log("NO SCREWDRIVER");
            }


        }
        for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "screw driver")
            {
                theControllerScript.ItemsinInventory[i] = "";
            }
        }

    }
}
