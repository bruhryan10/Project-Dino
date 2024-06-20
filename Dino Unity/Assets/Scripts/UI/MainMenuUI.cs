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
    [SerializeField] GameObject[] sign;



    void Start()
    {
        Time.timeScale = 1f;
        DisableImages();
        sign[0].SetActive(true);
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

    public void Credits()
    {
        if (credits.activeInHierarchy)
            credits.SetActive(false);
        else
        {
            controls.SetActive(false);
            credits.SetActive(true);
        }
    }
    public void Controls()
    {
        if (controls.activeInHierarchy)
            controls.SetActive(false);
        else
        {
            controls.SetActive(true);
            credits.SetActive(false);
        }
    }
}
