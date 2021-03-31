using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class sendscore : MonoBehaviour
{
    public GameObject currentTime;
    void OnDisable()
    {
        Text Time = currentTime.GetComponent<Text>();
        int intTime = System.Convert.ToInt32(Time.text);

        PlayerPrefs.SetInt("time", intTime);
    }
}
