using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject playerCamera;
    public Animator anim;
    Rigidbody rb;


    public float movementSpeed = 3;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    private float canJump = 0f;
    public bool canMove;
    public bool isOccupied;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        canMove = true;
    }

    void Update()
    {
        if (canMove)
        {
            ControllPlayer();
        }
        
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        float facing = playerCamera.transform.eulerAngles.y;

        if (moveVertical < 0)
            moveVertical = 0;

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Vector3 myTurnedInputs = Quaternion.Euler(0, facing, 0) * movement;

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(myTurnedInputs), 0.5f);
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        transform.Translate(myTurnedInputs * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetButtonDown("Jump") && Time.time > canJump)
        {
            rb.AddForce(0, jumpForce, 0);
            canJump = Time.time + timeBeforeNextJump;
            anim.SetTrigger("jump");
        }
    }
}