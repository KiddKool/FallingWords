using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public InputField input;

    public void setName()
    {
        PlayerPrefs.SetString("Player", input.text);
    }
}
