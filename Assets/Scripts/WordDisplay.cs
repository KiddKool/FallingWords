using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallspeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(0f, WordSpeed.fallspeed * -fallspeed * Time.deltaTime, 0f);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "destroyer")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
