using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemies : MonoBehaviour
{
    private PlayerScript playerscript;
    public GameObject PlayerPos;
    private EnemyController enemyaccess;

    public GameObject[] enemies;

    // Start is called before the first frame update
    void Awake()
    {
        playerscript = GetComponent<PlayerScript>();
    }
    private void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        enemyaccess.animator.SetBool("Alive", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B Pressed");
            playerscript.lightIntensity = playerscript.lightIntensity + 7;

            for (int hh = 0; hh < enemies.Length; hh++)
            {
                if (Mathf.Abs(PlayerPos.transform.position.x-enemies[hh].transform.position.x)<=2)
                {
                    enemyaccess.animator.SetBool("Alive", false); 
                    enemies[hh].GetComponent<SpriteRenderer>().enabled = false;
                   // enemies[hh].GetComponent<PolygonCollider2D>().enabled = false;
                    enemies[hh].GetComponent<CircleCollider2D>().enabled = false;
                }
            }

        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            playerscript.lightIntensity = playerscript.lightIntensity - 10;
        }
    }
}


