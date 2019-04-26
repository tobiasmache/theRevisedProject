using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    [SerializeField] private string newLevel;
    GameObject[] Enemies;
    public GameObject EnemyPrefab;
    private Vector3 epos;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }

    private void Awake()
    {
  
    }

    void LevelBuilder()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
