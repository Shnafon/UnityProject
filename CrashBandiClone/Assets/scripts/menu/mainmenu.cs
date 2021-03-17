using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class mainmenu : MonoBehaviour
{
    public GameObject sm;
    public GameObject om;
    public GameObject pm;

    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame ()
    {
        SceneManager.LoadScene(1);
    }
    public void Die()
    {
        SceneManager.LoadScene(2);
    }
    public void displayoptions()
    {
        om.SetActive(true);
        sm.SetActive(false);
    }
    public void Back()
    {
        sm.SetActive(true);
        om.SetActive(false); 
    }
    public void Pause()
    {
        pm.SetActive(true);
    }
    public void unpause()
    {
        pm.SetActive(false);
    }
}
