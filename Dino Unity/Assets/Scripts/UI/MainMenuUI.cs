using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] Canvas UI;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject controls;
    [SerializeField] GameObject player;

    void Start()
    {
        Time.timeScale = 1f;
        DisableImages();
    }
    void DisableImages()
    {
        credits.SetActive(false);
        controls.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits(bool text)
    {
        if (text)
        {
            Time.timeScale = 0;
            player.GetComponent<PlayerMovement>().SetMovementStatus(true);
            player.GetComponent<SpriteRenderer>().enabled = false;
            credits.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            player.GetComponent<PlayerMovement>().SetMovementStatus(false);
            player.GetComponent<SpriteRenderer>().enabled = true;
            credits.SetActive(false);
        }
    }
    public void Controls(bool text)
    {
        if (text)
        {
            Time.timeScale = 0;
            player.GetComponent<PlayerMovement>().SetMovementStatus(true);
            player.GetComponent<SpriteRenderer>().enabled = false;
            controls.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
            player.GetComponent<PlayerMovement>().SetMovementStatus(false);
            player.GetComponent<SpriteRenderer>().enabled = true;
            controls.SetActive(false);
        }
    }
}
