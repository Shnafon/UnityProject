using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpRoomButton : MonoBehaviour
{
    private Renderer renderer;
    public short Level = 0;
    public Texture normal;
    public Texture pressed;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Touch");
        renderer.material.mainTexture = pressed;
        GameObject.Find("portal").GetComponent<WarpRoomPortal>().setLevel(Level);
    }

    void OnTriggerExit(Collider other)
    {
        renderer.material.mainTexture = normal;
    }
}
