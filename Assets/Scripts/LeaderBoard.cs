using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Xml.Serialization;
[System.Serializable]
public class LeaderBoard : MonoBehaviour
{
    public string player1;
    public GameObject player1D;
    public string score;
    public GameObject player1Ds;
    public string readFiletext;

    public List<HighScoreEntry> list = new List<HighScoreEntry>();
    public HighScoreDisplay[] highScoreDisplayArray;
    public LeaderBoard leaderboard;

    public static LeaderBoard instance;

    void Awake()
    {
        instance = this;
    }

    // Int score
    // Start is called before the first frame update
    public void Start()
    {
        GameManager.Load();
        GameManager.Save();
        // Adds some test data
        GameManager.AddNewScore("John", 4500);
        GameManager.AddNewScore("Max", 5520);
        GameManager.AddNewScore("Dave", 380);
        GameManager.AddNewScore("Steve", 6654);
        GameManager.AddNewScore("Mike", 11021);
        GameManager.AddNewScore("Teddy", 3252);

        UpdateDisplay();

        
        ShowName();
        //if(!)
        //string path = @"my_file.txt";
        //StreamWriter sw = File.CreateText(path);
    }

    public void UpdateDisplay()
    {
        GameManager.scores.Sort((HighScoreEntry x, HighScoreEntry y) => y.score.CompareTo(x.score));

        for (int i = 0; i < highScoreDisplayArray.Length; i++)
        {
            if (i < GameManager.scores.Count)
            {
                highScoreDisplayArray[i].DisplayHighScore(GameManager.scores[i].name, GameManager.scores[i].score);
            }
            else
            {
                highScoreDisplayArray[i].HideEntryDisplay();
            }
        }
    }
    public void ShowName()
    {
        player1D.GetComponent<Text>().text = PlayerPrefs.GetString("user_name");
        player1Ds.GetComponent<Text>().text = PlayerPrefs.GetInt("score").ToString();
    }


}
