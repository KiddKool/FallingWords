using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;

    private bool hasActiveWords;
    private Word activeWord;



    public void AddWord()
    {
        

        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter(char letter)
    {
        if (hasActiveWords)
        {
            if(activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if(word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    hasActiveWords = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        if(hasActiveWords && activeWord.WordTyped())
        {
            hasActiveWords = false;
            words.Remove(activeWord);
        }
    }

}
