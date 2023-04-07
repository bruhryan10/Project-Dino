using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;


public class PlainsUI : MonoBehaviour
{
    PlayerMovement playerMovement;
    public Canvas MainUI;
    public Canvas EndUI;
    public TMP_Text startRunning;
    public float runTimer;
    void Start()
    {
        Time.timeScale = 1f;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        runTimer = 4f;
        MainUI.enabled = true;
        EndUI.enabled = false;
    }

    void Update()
    {
        runTimer -= Time.deltaTime;
        if (runTimer <= 0)
        {
            MainUI.enabled = false;
        }
        if (playerMovement.endLevel == true)
        {
            Time.timeScale = 0f;
            EndUI.enabled = true;
        }
    }
    public void LoadTundra()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Tundra1");
    }
}
