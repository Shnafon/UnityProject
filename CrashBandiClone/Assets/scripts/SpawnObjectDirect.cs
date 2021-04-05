using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectDirect : MonoBehaviour
{
    public GameObject player;
    public GameObject ObjectToSpawn;
    public int distance;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Vector3 playerPos = player.transform.position;
            Instantiate(ObjectToSpawn, playerPos + player.transform.forward * distance, Quaternion.identity);
        }
        
    }
}
