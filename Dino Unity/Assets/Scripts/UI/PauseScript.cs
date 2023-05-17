using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{
    PlayerMovement playerMovement;
    public Canvas PauseMenuUI;
    public bool paused = false;
    public bool pausedMovement;


    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        PauseMenuUI.enabled = false;
    }

    void Update()
    {
        if (playerMovement.endLevel)
            return;
        if (playerMovement.isDead)
            return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
                resumeGame();
            else
                pauseGame();
        }
    }

    public void resumeGame()
    {
        PauseMenuUI.enabled = false;
        Time.timeScale = 1f;
        paused = false;
        pausedMovement = false;
    }
    public void pauseGame()
    {
        PauseMenuUI.enabled = true;
        Time.timeScale = 0f;
        paused = true;
        pausedMovement = true;

    }
    public void MainMenu()
    {
        resumeGame();
        SceneManager.LoadScene("Main Menu");
    }
    //public void MainMenuTundra()
    //{
    //    resumeGame();
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("Main Menu Tundra");
    //}
    public void QuitGame()
    {
        resumeGame();
        Application.Quit();
    }
    public void RestartEasy()
    {
        resumeGame();
        SceneManager.LoadScene("PlainsEasy");
    }
    //public void RestartHard()
    //{
    //    resumeGame();
    //    SceneManager.LoadScene("PlainsHard");
    //}
    //public void RestartFreeplayPlains()
    //{
    //    resumeGame();
    //    SceneManager.LoadScene("PlainsFreePlay");
    //}
}
