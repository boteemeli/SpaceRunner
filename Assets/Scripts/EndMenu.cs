using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    public GameObject ScoreImplement1;
    public string score1;
    public int score1_int;
    // Start is called before the first frame update
    void Start()
    {
        score1 = PlayerPrefs.GetInt("score").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
