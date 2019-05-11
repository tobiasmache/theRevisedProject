using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform Enemy;
    private Vector3 enemyPosition;

    void Awake()
    {
        enemyPosition = Enemy.transform.position;

    }
   
    // Update is called once per frame
    void Update()
    {
        if (GlobalVariableStorer.Instance.SceneNumber ==1)
        {
            Enemy.localPosition = new Vector3(Mathf.Lerp(enemyPosition.x - 2, enemyPosition.x, Mathf.PingPong(Time.time * .5f, 1)), enemyPosition.y, 0f);
            Debug.Log("slow");
        }
        else
        {
            Enemy.localPosition = new Vector3(Mathf.Lerp(enemyPosition.x-4, enemyPosition.x, Mathf.PingPong(Time.time * .5f, 1)), enemyPosition.y, 0f);
        }
        

    }
}
