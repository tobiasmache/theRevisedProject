using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Tilemaps;

public class GameController : MonoBehaviour
{
    public static GameController Instance;
    public string[] Levels;

    public Canvas MainMenuCanvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject helpMenu;
    public GameObject creditMenu;

    public GameObject connectorToChangeHearts;
    private ChangeHearts changehearts;


    public void PlayGame()
    {
        MainMenuCanvas.GetComponent<Canvas>().enabled = false;
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

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void SceneChange(int lc, int health)
    {
        Debug.Log("Level Count" + (lc-1));
        SceneManager.LoadScene(Levels[lc-1]);
    }

    private void Awake()
    {
        changehearts = connectorToChangeHearts.GetComponent<ChangeHearts>();
    }

    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


