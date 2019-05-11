using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform PlayerRestart;
    private ChangeHearts changehearts;
    public CharacterController2D controller;
    public Animator animator;

    public GameObject connectorToGameController;
    private GameController gamecontroller;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    private int jumpCounter = 0;

    public int health=0;
    private int LevelCount=-1;
    public int lightIntensity = 7;
    public Light Firefly;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    public GameObject[] collectables;

    // Start is called before the first frame update
    private void Start()
    {
        collectables = GameObject.FindGameObjectsWithTag("Collectable");
        Debug.Log("collectables in Scene= "+collectables.Length);

        //Load Saved Data into Game
        health = GlobalVariableStorer.Instance.health;
        lightIntensity = GlobalVariableStorer.Instance.lightIntensity;
        LevelCount = GlobalVariableStorer.Instance.SceneNumber;
        changehearts.UpdateHearts(health);

        if (LevelCount == 0)
        {
            lightIntensity = 7;
        }
    }
    void Awake()
    {
        changehearts = GetComponent<ChangeHearts>();
        gamecontroller = connectorToGameController.GetComponent<GameController>();
        changehearts.CreateHearts(heart1, heart2, heart3);
        Debug.Log("CreateHearts");
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Grounded:" + controller.m_Grounded);
            if (jumpCounter <= 0 && controller.m_Grounded == false )
            {
                Debug.Log("Jump");
                jump = true;
                jumpCounter++;
            }
            else if (controller.m_Grounded==true)
            {
                jump = true;
                jumpCounter = 0;
            }

        }

        Firefly.intensity = lightIntensity;
    }

    private void FixedUpdate()
    {
        //move character
        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;
        //jumpCounter = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            for (int ii = 0; ii < collectables.Length; ii++)
            {
                if (other.gameObject == collectables[ii])
                {
                    collectables[ii].GetComponent<SpriteRenderer>().enabled = false;
                    collectables[ii].GetComponent<PolygonCollider2D>().enabled = false;
                }
            }
            lightIntensity = lightIntensity + 5;
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
            health++;
            changehearts.UpdateHearts(health);

        }
        if (other.gameObject.CompareTag("Spike"))
        {
            PlayerRestart.position = new Vector3(-6.2f, 5.4f, 0f);
            health++;
            changehearts.UpdateHearts(health);
        }

        if (other.gameObject.CompareTag("Portal"))
        {
            Debug.Log("PORTAL"+LevelCount);
            LevelCount++;
            SavePlayerData();
            gamecontroller.SceneChange(LevelCount,health);
        }
        if (other.gameObject.CompareTag("Tilemap"))
        {
            //controller.jumpCount = 0;
        }
    }

    public void SavePlayerData()
    {
        Debug.Log("Health= "+health);
        GlobalVariableStorer.Instance.health = health;
        GlobalVariableStorer.Instance.lightIntensity = lightIntensity;
        GlobalVariableStorer.Instance.SceneNumber = LevelCount;
    }
}

