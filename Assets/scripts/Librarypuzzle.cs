using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Brandon Salter
//this script is used to complete the final puzzle in the library
public class Librarypuzzle : MonoBehaviour
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
            if (newItem.text == "vault key")
            {
                theControllerScript.deletePosition += 1;
                newItem.text = "";
                theControllerScript.ItemsToDelete[theControllerScript.deletePosition - 1] = "vault key";
                Destroy(gameObject);
            }

            else
            {
                Debug.Log("nope");
            }

        }
    }
}
