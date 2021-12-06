using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderBoard : MonoBehaviour
{
    public string player1;
    public GameObject player1D;
    public string score;
    public GameObject player1Ds;
    // Start is called before the first frame update
    public void Start()
    {
        ShowName();
    }


    public void ShowName()
    {
        player1D.GetComponent<Text>().text = PlayerPrefs.GetString("user_name");
        player1Ds.GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
    }
}
