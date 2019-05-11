using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_Phase2 : MonoBehaviour
{
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public GameObject box1;
    public GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        //text3.GetComponent<Text>().enabled = false;
        text4.GetComponent<Text>().enabled = false;
        text5.GetComponent<Text>().enabled = false;
        text6.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D player)
    {
       
        text1.GetComponent<Text>().enabled = false;
        text2.GetComponent<Text>().enabled = false;
        text3.GetComponent<Text>().enabled = false;
        text4.GetComponent<Text>().enabled = true;
        text5.GetComponent<Text>().enabled = true;
        text6.GetComponent<Text>().enabled = true;


    }

}
