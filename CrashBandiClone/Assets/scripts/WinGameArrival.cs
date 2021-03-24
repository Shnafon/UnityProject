using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinGameArrival : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("player win");
        SceneManager.LoadScene("OutroCutscene");
    }
}
