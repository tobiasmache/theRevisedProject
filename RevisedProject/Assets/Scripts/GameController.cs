using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    bool levelstart;
    int LevelCount=0;

    public string[] Levels;

    //[SerializeField] private string newLevel;
    //GameObject[] Enemies;
    //public GameObject EnemyPrefab;
    //private Vector3 epos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(LevelCount);
        }
        LevelCount++;
    }

    private void Awake()
    {
        //Levels = new string[5];
    }

    void LevelBuilder()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
