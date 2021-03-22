using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnTrapCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collision");
        Debug.Log(other.gameObject.name);
        SceneManager.LoadScene(2);
    }
}
