using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    bool gamestart = false;
    public string[] Levels;

    public Canvas MainMenuCanvas;

    public void PlayGame()
    {
        gamestart = true;

    }

    public void SceneChange(int lc)
    {
        Debug.Log("Level Count" + lc);
        SceneManager.LoadScene(Levels[lc]);
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
        if (gamestart == true)
        {
            MainMenuCanvas.GetComponent<Canvas>().enabled = false;
        }
    }
}


