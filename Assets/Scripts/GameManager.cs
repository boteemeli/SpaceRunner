using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public Text scoreText;
    // Start is called before the first frame update
    public void ScoreOutPut()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
    private void Awake()
    {
        inst = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
