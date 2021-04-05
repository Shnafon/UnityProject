using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CustceneSkip : MonoBehaviour
{
    public bool endingCustcene = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.X))
        {
            if (!endingCustcene)
                SceneManager.LoadScene("MazeTest");
            else
                SceneManager.LoadScene("WinScreen");
        }
    }
}
