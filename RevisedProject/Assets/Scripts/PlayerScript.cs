using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Awake()
    {
        changehearts = GetComponent<ChangeHearts>();
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
            Debug.Log("Jump");
            jump = true;
        }

        Firefly.intensity = lightIntensity;
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
            GameObject.Find("Collectable").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("Collectable").GetComponent<PolygonCollider2D>().enabled = false;
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
}


