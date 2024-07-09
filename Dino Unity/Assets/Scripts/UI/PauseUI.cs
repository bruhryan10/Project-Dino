using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    PlayerMovement playerMovement;
    [SerializeField] Canvas UI;
    bool paused;

    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        UI.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused == true)
                ResumeGame();
            else
                PauseGame();
        }
    }
    public void ResumeGame()
    {
        UI.enabled = false;
        Time.timeScale = 1f;
        paused = false;
    }
    void PauseGame()
    {
        UI.enabled = true;
        Time.timeScale = 0f;
        paused = true;
    }
    public void QuitGame()
    {
        ResumeGame();
        Application.Quit();
    }
}
