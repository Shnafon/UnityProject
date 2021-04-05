using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
    public GameObject player;
    public AudioClip jump_sfx;
    public AudioSource sfx_source;

    // Update is called once per frame
    void Update()
    {

        
        if (controller.isGrounded)
        {
            player.GetComponent<Animator>().SetBool("Jumping", false);
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (moveDirection == Vector3.zero)
            {
                Debug.Log("not moving");
                player.GetComponent<Animator>().SetBool("Running", false);
            }
            else
            {
                Debug.Log("moving");
                player.GetComponent<Animator>().SetBool("Running", true);
            }
            if (Input.GetButton("Jump"))
            {
                sfx_source.clip = jump_sfx;
                sfx_source.Play();
                moveDirection.y = jumpSpeed;
                Debug.Log("Jump");
                player.GetComponent<Animator>().SetBool("Running", false);
                player.GetComponent<Animator>().SetBool("Jumping", true);
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        //Rotate Player
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime, 0);

    }
}
