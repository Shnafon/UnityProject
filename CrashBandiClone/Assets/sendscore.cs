using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sendscore : MonoBehaviour
{
    public GameObject currentCandy;
    void OnDisable()
    {
        Text playerScore = currentCandy.GetComponent<Text>();
        int intplayerScore = System.Convert.ToInt32(playerScore.text);

        PlayerPrefs.SetInt("score", intplayerScore);
    }
}
