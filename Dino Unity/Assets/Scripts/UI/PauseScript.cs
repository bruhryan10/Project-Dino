using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseScript : MonoBehaviour
{
    public Canvas PauseMenuUI;
    public bool paused = false;
    public bool pausedMovement;
    PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        PauseMenuUI.enabled = false;
    }

    void Update()
    {
        if (playerMovement.endLevel)
        {
            return;
        }
        if (playerMovement.isDead)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
            {
                resumeGame();
            }
            else
            {
                pauseGame();
            }
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
    public void QuitGame()
    {
        resumeGame();
        Application.Quit();
    }
    public void Restart()
    {
        resumeGame();
        SceneManager.LoadScene("Plains1");

    }
}
