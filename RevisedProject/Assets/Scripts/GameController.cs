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
        SceneManager.LoadScene(GlobalVariableStorer.Instance.LevelNames[lc]);
    }

    private void Awake()
    {
        changehearts = connectorToChangeHearts.GetComponent<ChangeHearts>();
    }

    private void Start()
    {
        if (GlobalVariableStorer.Instance.SceneNumber == 0)
        {
            GlobalVariableStorer.Instance.LevelNames = new string[Levels.Length];
            for (int ii = 0; ii < Levels.Length; ii++)
            {
                GlobalVariableStorer.Instance.LevelNames[ii] = Levels[ii];
            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}


