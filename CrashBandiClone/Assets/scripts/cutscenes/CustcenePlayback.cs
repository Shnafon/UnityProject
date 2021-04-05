using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class CustcenePlayback : MonoBehaviour
{
    public bool endingCutscene;
    public VideoPlayer  videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (videoPlayer.clockTime >= videoPlayer.length)
        {
            if (endingCutscene)
                SceneManager.LoadScene("WinScreen");
            else
                SceneManager.LoadScene("MazeTest");
        }
    }
}
