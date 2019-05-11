using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Transform PlayerRestart;
    private ChangeHearts changehearts;
    public CharacterController2D controller;
    public Animator animator;

    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false;

    public int lightIntensity = 7;
    public Light Firefly;

    public GameObject heart1;
    public GameObject heart2; 
    public GameObject heart3;
    private int health;
    public static int Scorecounter = 0;
    public Text Score;
    public GameObject[] collectables;

    // Start is called before the first frame update
    private void Start()
    {
        collectables= GameObject.FindGameObjectsWithTag("Collectable");
        Debug.Log(collectables.Length);
    }
    void Awake()
    {
        changehearts = GetComponent<ChangeHearts>();
        changehearts.CreateHearts(heart1, heart2, heart3);
        Debug.Log("CreateHearts");
    }

    // Update is called once per frame
    void Update()
    {
        ;
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump");
            jump = true;
        }

        Firefly.intensity = lightIntensity;
        PrintScore();
    }

    private void FixedUpdate()
    {
        //move character

        controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
        jump = false;

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            for(int ii=0; ii < collectables.Length; ii++)
            {
                if (other.gameObject == collectables[ii])
                {
                    collectables[ii].GetComponent<SpriteRenderer>().enabled = false;
                    collectables[ii].GetComponent<PolygonCollider2D>().enabled = false;
                    Scorecounter = Scorecounter + 5;

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
    }
    void PrintScore()
    {

        Score.text =  Scorecounter.ToString();
        Debug.Log(Scorecounter);
    }

}

