using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayText : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return)) { StoreName(); }
    }

    public void StoreName()
    {
        theName = inputField.GetComponent<Text>().text;
        //PlayerPrefs.SetString("user_name", textDisplay.GetComponent<Text>().text);
        //PlayerPrefs.Save();
        //textDisplay.GetComponent<Text>().text = "Welcome " + PlayerPrefs.GetString("user_name") + " to the game.";
        
    }
}
