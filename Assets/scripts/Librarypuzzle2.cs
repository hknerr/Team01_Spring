using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Brandon
//door 2
//this script is to make sure the person playing the game has found the statues around the rooms
public class Librarypuzzle2 : MonoBehaviour
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
            if (newItem.text == "Statue 1")
            {

                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "Statue 1";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("find statue 1");
            }

        }
    }
}
