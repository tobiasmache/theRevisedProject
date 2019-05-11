using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject Respawnlocation;
    public PlayerScript playerScript;
    //public bool movecharacter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Respawning()
    {

        playerScript.PlayerRestart.position = Respawnlocation.GetComponent<Transform>().position;
        //playerScript.movecharacter = false;

       

    }
}
