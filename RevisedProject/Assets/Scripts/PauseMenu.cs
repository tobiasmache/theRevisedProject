using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseMenuCanvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject helpMenu;
    public GameObject creditMenu;

    public static bool GameIsPaused = false;

    private int LevelCount;
    private int health;
    public int lightIntensity;

    // Start is called before the first frame update
    void Start()
    {
        LevelCount = GlobalVariableStorer.Instance.SceneNumber;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            {
            Debug.Log("Escape");
            if (GameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                Pause();
                Debug.Log("Paused");
            }
                
            }
    }

    public void ResumeGame()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void OptionsPressed()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void BackPressed()
    {
        optionsMenu.SetActive(false);
        mainMenu.SetActive(true);
        helpMenu.SetActive(false);
        creditMenu.SetActive(false);
    }
    public void HelpPressed()
    {
        mainMenu.SetActive(false);
        helpMenu.SetActive(true);
    }
    public void CreditsPressed()
    {
        mainMenu.SetActive(false);
        creditMenu.SetActive(true);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        SceneManager.LoadScene("MenuTutorial");
        LevelCount = 0;
        health = 0;
        lightIntensity = 7;
        SavePlayerData();
    }

    public void SavePlayerData()
    {
        GlobalVariableStorer.Instance.health = health;
        GlobalVariableStorer.Instance.lightIntensity = lightIntensity;
        GlobalVariableStorer.Instance.SceneNumber = LevelCount;
    }
}
