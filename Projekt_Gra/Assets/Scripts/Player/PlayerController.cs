using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody RB;

    public float Speed;
    public float SprintSpeed;
    public float JumpForce;
    public bool InSprint;
    
  

    //public bool IsGrounded;
    // public LayerMask GroundMask; // czy kula odtyka podloza

    float Horizontal;
    float Vertical;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        //IsGrounded = Physics.CheckSphere(new Vector3(transform.position.x, transform.position.y - 1.7f, transform.position.z), 0.5f (wielkosc kuli) , GroundMask (maska, wartwa, inna niz naszego gracz));

        if (InSprint == true)
        {
            Horizontal = Input.GetAxis("Horizontal") * SprintSpeed;
            Vertical = Input.GetAxis("Vertical") * SprintSpeed;
        }
        else
        {
            Horizontal = Input.GetAxis("Horizontal") * Speed;
            Vertical = Input.GetAxis("Vertical") * Speed;
        }

        Vector3 MovePosition = transform.right * Horizontal + transform.forward * Vertical;
        Vector3 NewMovePosition = new Vector3(MovePosition.x, RB.velocity.y, MovePosition.z);

        RB.velocity = NewMovePosition;
        /*
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded)
        {
            RB.velocity = new Vector3(RB.velocity.x, JumpForce, RB.velocity.z);
        } */

        if (Input.GetKey(KeyCode.LeftShift)) // && IsGrounded)
        {
            InSprint = true;
        }
        else
        {
            InSprint = false;
        }

      
    }
}