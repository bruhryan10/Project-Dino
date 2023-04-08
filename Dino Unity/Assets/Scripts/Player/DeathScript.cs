using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{

    public Canvas deathUI;
    PlayerMovement playerMovement;
    public bool isNotDead;


    public Animator playerAnim;

    void Start()
    {
        deathUI.enabled = false;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();

    }

    void Update()
    {
        if (playerMovement.isDead && isNotDead == false)
        {
            IsDead();
            playerAnim.SetTrigger("Death");
        }
    }

    public void IsDead()
    {
        Time.timeScale = 0f;
        deathUI.enabled = true;
    }
    public void IsNotDead()
    {
        isNotDead = true;
        Time.timeScale = 1f;
        deathUI.enabled = false;
    }
    public void MainMenu()
    {
        IsNotDead();
        SceneManager.LoadScene("Main Menu");

    }
    public void QuitGame()
    {
        IsNotDead();
        Application.Quit();
    }
    public void RestartEasy()
    {
        IsNotDead();
        SceneManager.LoadScene("Plains1");

    }
    public void RestartHard()
    {
        IsNotDead();
        SceneManager.LoadScene("PlainsHard");

    }
}
