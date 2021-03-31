using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class getscore : MonoBehaviour
{
    public GameObject scoreInt;
    void Awake()
    {
        int score = PlayerPrefs.GetInt("score");
        Text scoretext = scoreInt.GetComponent<Text>();
        scoretext.text = System.Convert.ToString(score);
    }
}
