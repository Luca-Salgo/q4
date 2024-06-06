
using JetBrains.Annotations;
using System;
using System.Collections;
using UnityEngine;


public class moving : MonoBehaviour
{
    public CharacterController controller;
    public Transform player;


    public float moveSpeed;
    public float sprintSpeed;




    public float gravity;
    public float jumpHeight;
    public Transform ground;


    public Transform groundCheck;
    public float groundDistance;
    public LayerMask groundMask;

    bool isGrounded;
    Vector3 velocity;



    void Update()
    {



        //ground checking
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        //clamping player to the ground
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -1f;
        }



        //moving on the ground
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");


        Vector3 move = transform.right * x + transform.forward * z;


        if (Input.GetKeyDown(KeyCode.LeftShift))
            moveSpeed += sprintSpeed;
        else if(Input.GetKeyUp(KeyCode.LeftShift))
            moveSpeed -= sprintSpeed;








        //jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }


        controller.Move(move * moveSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);






        }



    }

   








