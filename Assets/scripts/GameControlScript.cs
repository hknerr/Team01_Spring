using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour
{
    //Singleton class to manage persistence between scenes
    //static reference to the instance of the GameControlScript
    public static GameControlScript instance;

    public bool GameOver = false;

    public int invposition = 0;
    public int deletePosition = 0;
    public int statueinvposition = 0;

    public string[] ItemsinInventory = new string[10];
    public string[] ItemsToDelete = new string[20];
    public string[] StatuesInInventory = new string[2];


    void Awake()
    {
        //if the instance reference has not beem set yet
        if (instance == null)
        {
            //set this instance as the instance reference
            instance = this;
        }
        else if (instance != this)
        {
            // if the instance reference is already set and this is not the instance reference
            // destroy the game object
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

}
