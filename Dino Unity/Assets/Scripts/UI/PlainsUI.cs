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
    [SerializeField] Canvas MainUI;
    [SerializeField] GameObject start;
    [SerializeField] GameObject continueButton;
    [SerializeField] float runTimer;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        runTimer = 4f;
        Time.timeScale = 1f;
        MainUI.enabled = true;
        continueButton.SetActive(false);
    }

    void Update()
    {
        if (start.activeInHierarchy)
            runTimer -= Time.deltaTime;
        if (runTimer <= 0)
            start.SetActive(false);
    }
    public void LoadTundraEasy()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("TundraEasy");
    }
}
