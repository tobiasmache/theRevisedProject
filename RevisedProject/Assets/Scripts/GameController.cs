using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    bool gamestart = false;
    bool optionsp = false;
    bool backs = false;
    public string[] Levels;

    public Canvas MainMenuCanvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void PlayGame()
    {
        gamestart = true;
    }

    public void OptionsPressed()
    {
        optionsp = true;
    }

    public void BackPressed()
    {
        backs = true;
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
        if (optionsp == true)
        {
            mainMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }
        if (backs == true)
        {
            optionsp = false;
            backs = false;
            optionsMenu.SetActive(false);
            mainMenu.SetActive(true);  
        }
    }
}


