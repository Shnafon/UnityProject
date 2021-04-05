using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gettime : MonoBehaviour
{
    public GameObject timeInt;
    void Awake()
    {
        float time = PlayerPrefs.GetFloat("time");
        int timeint = (int)time;
        int timin = timeint/60;
        int timsec = timeint%60;
        Text timetext = timeInt.GetComponent<Text>();
        
        timetext.text = string.Format("{0:00}:{1:00}", timin, timsec);
        //timetext.text = System.Convert.ToString(timin) + ":" + System.Convert.ToString(timsec);
    }

}
