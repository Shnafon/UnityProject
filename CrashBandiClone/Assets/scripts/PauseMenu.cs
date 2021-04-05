using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private GameObject[] pauseUI;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        pauseUI = GameObject.FindGameObjectsWithTag("pauseUI");
        foreach (GameObject g in pauseUI)
        {
            g.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                showPaused();
                Time.timeScale = 0;
            }
            else
            {
                hidePaused();
                Time.timeScale = 1;
            }
        }
    }

    public void showPaused()
    {
        foreach(GameObject g in pauseUI)
        {
            g.SetActive(true);
        }
    }

    public void hidePaused()
    {
        foreach (GameObject g in pauseUI)
        {
            g.SetActive(false);
        }
    }
}
