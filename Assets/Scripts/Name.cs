using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text showName;
    void Start()
    {
        showName.text = PlayerPrefs.GetString("Player");
    }

}
