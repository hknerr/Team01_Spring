using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneChangeTracker : MonoBehaviour
{
    public GameObject theGameController;
    public GameControlScript theControllerScript;
    public GameObject invGameObj;
    public Text newItem;
    public GameObject itemToDelete;

    void OnEnable()
    {
        theGameController = GameObject.Find("GameController");
        theControllerScript = theGameController.GetComponent<GameControlScript>();

        for (int i = 0; i < 10; i++)
        {
            invGameObj = GameObject.Find("Canvas/Vertical Panel/Inventory" + (i+1));
            newItem = invGameObj.GetComponent<Text>();
            newItem.text = theControllerScript.ItemsinInventory[i];


            Debug.Log("Setting inv position" + i);
        }

        for (int i = 0; i < 10; i++)
        {
            itemToDelete = GameObject.Find(theControllerScript.ItemsinInventory[i]);
            GameObject.Destroy(itemToDelete);

        }


    }
}
