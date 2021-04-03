using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreDisplay;
    public Text Highscore;
   
    void Start()
    {
        score = 0;
        
    }
    
 

    void Update()
    {
        scoreDisplay.text = score.ToString();
        PlayerPrefs.SetInt("WordCount", score);
    }

    public void Restart()
    {

        PlayerPrefs.DeleteKey("WordCount");
       
    }
}
