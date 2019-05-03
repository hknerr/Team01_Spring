using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Nicks code
/// Hunters code
/// Makes it so that that user has to click on objects to remove the bars to unlock the door and get the key
/// </summary>
public class catacombsunlock : MonoBehaviour
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
            if (newItem.text == "skeleton key")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "cellar door key";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("no skeleton key");
            }

        }
        for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "skeleton key")
            {
                theControllerScript.ItemsinInventory[i] = null;
            }
        }

    }
}
