using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class MovementOnly_PlayerScript : MonoBehaviour

{
    public CharacterController2D controller;
    //public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    private int jumpCounter = 0;
    public int health = 0;
    private int LevelCount = -1;
    public int lightIntensity = 7;
    //public Light Firefly;





    // Start is called before the first frame update
    private void Start()
    {

    }

    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        //animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Grounded:" + controller.m_Grounded);
            if (jumpCounter <= 0 && controller.m_Grounded == false)
            {
                Debug.Log("Jump");
                jump = true;
                jumpCounter++;
            }
            else if (controller.m_Grounded == true)
            {
                jump = true;
                jumpCounter = 0;
            }

        }


    }

    private void FixedUpdate()
    {
        //move character

        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
    }




}

