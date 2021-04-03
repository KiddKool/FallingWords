using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpeed : MonoBehaviour
{
    public static float fallspeed = 1f;
    public void AdjustSpeed(float newSpeed)
    {
        fallspeed = newSpeed;
    }
}
