using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform Enemy;
    private Vector3 enemyPosition;
    public Animator animator;
    public bool alive;


    void Awake()
    {
        enemyPosition = Enemy.transform.position;
        //animator.SetBool("Alive", false);
        alive = true;
    }
   
    // Update is called once per frame
    void Update()
    {
        Enemy.localPosition = new Vector3(Mathf.Lerp(enemyPosition.x-1, enemyPosition.x+1f, Mathf.PingPong(Time.time * .5f, 1)), enemyPosition.y, 0f);

        if (alive == false)
        {
            animator.SetBool("Alive", false);
        }

    }
}
