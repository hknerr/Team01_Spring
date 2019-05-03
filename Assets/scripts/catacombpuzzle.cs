using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Nicks code
/// Catacombs puzzle for the skull head
/// attached to skull head
/// </summary>

public class catacombpuzzle : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public Text myText;
    public Text newItem;
    public GameObject myGameObject;
    public GameObject invGameObj;
    public GameObject itemToDelete;

    void Start()
    {
        // Hide skull
        GameObject.Find("skullhead").transform.localPosition = new Vector3(100, 100, 0);
    }
    private void OnMouseDown()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();


        for (int i = 0; i < 10; i++)
        {
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + (i + 1));
            newItem = invGameObj.GetComponent<Text>();
            if (newItem.text == "skull")
            {
            
                newItem.text = "";
                

                // Show skull
                GameObject.Find("skullhead").transform.localPosition = new Vector3(0.16f, -2.11f, 0f);

                itemToDelete = GameObject.Find("cellar door locked");
                GameObject.Destroy(itemToDelete);
            }

            else
            {
                Debug.Log("hhh");
            }

        }
        for (int i = 0; i < 10; i++)
        {
            if (theControllerScript.ItemsinInventory[i] == "skull")
            {
                theControllerScript.ItemsinInventory[i] = "";
            }
        }

    }
}
