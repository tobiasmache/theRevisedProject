using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public Canvas MainMenuCanvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject helpMenu;
    public GameObject creditMenu;

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


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
