using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{

    public Text LastScore;
    void Start()
    {
        LastScore.text = PlayerPrefs.GetInt("WordCount").ToString();
    }

 
}
