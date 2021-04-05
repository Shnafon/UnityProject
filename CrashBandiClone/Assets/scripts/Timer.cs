using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float        remaining_time = 10;
    public GameObject   timerUI;
    private Text timerTextRef;
    // Start is called before the first frame update
    void Start()
    {
        timerTextRef = timerUI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (remaining_time > 0)
        {
            remaining_time -= Time.deltaTime;
            DisplayText(remaining_time);
        }
        else
        {
            SceneManager.LoadScene("game over");
        }
    }

    private void DisplayText(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerTextRef.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    void OnDisable()
    {
        PlayerPrefs.SetFloat("time", remaining_time);
    }
}
