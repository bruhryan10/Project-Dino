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
    Debugger debug;
    public Canvas MainUI;
    public Canvas EndUI;
    public TMP_Text startRunning;
    public float runTimer;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        debug = GameObject.Find("Player").GetComponent<Debugger>();
        runTimer = 4f;
        Time.timeScale = 1f;
        MainUI.enabled = true;
        EndUI.enabled = false;
    }

    void Update()
    {
        runTimer -= Time.deltaTime;
        if (runTimer <= 0)
            startRunning.enabled = false;
        if (playerMovement.endLevel == true)
        {
            Time.timeScale = 0f;
            EndUI.enabled = true;
        }
    }
    public void LoadTundraEasy()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TundraEasy");
    }
    //public void LoadTundraHard()
    //{
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("TundraHard");
    //}
    //public void LoadTundraFreePlay()
    //{
    //    Time.timeScale = 1f;
    //    SceneManager.LoadScene("TundraFreePlay");
    //}
}
