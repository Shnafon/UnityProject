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
        int timin = (int) time/60;
        int timsec = (int)(time - timin)/10;
        Text timetext = timeInt.GetComponent<Text>();
        timetext.text = System.Convert.ToString(timin) + ":" + System.Convert.ToString(timsec);
    }

}
