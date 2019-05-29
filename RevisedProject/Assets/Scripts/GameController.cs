using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public string[] Levels;

    public GameObject connectorToChangeHearts;
    private ChangeHearts changehearts;

    public void SceneChange(int lc, int health)
    {
        Debug.Log("Level Count" + (lc-1));
        SceneManager.LoadScene(Levels[lc-1]);
    }

    private void Awake()
    {
        //changehearts = connectorToChangeHearts.GetComponent<ChangeHearts>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


