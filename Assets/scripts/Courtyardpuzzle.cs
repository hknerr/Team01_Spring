using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//useless code
public class Courtyardpuzzle : MonoBehaviour
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
            if (newItem.text == "Statue 1" + "Statue 2" + "Statue 3")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "Statue 1" + "Statue 2" + "Statue 3";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("nope");
            }

        }
    }
}
