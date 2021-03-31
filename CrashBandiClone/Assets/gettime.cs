using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gettime : MonoBehaviour
{
    public GameObject timeInt;
    void Awake()
    {
        int time = PlayerPrefs.GetInt("time");
        Text timetext = timeInt.GetComponent<Text>();
        timetext.text = System.Convert.ToString(time);
    }

}
