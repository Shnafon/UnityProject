using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class collectable : MonoBehaviour
{
    public GameObject currentCandy;
    private void OnCollisionEnter(Collision collision)
    {
        Text fruittext =  currentCandy.GetComponent<Text>();
        int actualfruit = System.Convert.ToInt32(fruittext.text);
        fruittext.text = System.Convert.ToString(actualfruit + 1);
        Debug.Log("Wumpa Wumpa collectable");
        Destroy(this.gameObject);
    }
}
