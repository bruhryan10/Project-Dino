using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] Canvas UI;
    [SerializeField] GameObject plainsObj;
    [SerializeField] GameObject tundraObj;
    [SerializeField] List<TMP_Text> textColors;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject controls;
    [SerializeField] GameObject unusedAssets;
    [SerializeField] GameObject[] sign;

    int testCount;
    int menu;


    void Start()
    {
        Time.timeScale = 1f;
        menu = 0;
        DisableImages();
        sign[0].SetActive(true);
    }
    public void DebugLogTest()
    {
        testCount++;
        Debug.Log("Debug Log Test Ran! " + testCount);
    }
    void DisableImages()
    {
        credits.SetActive(false);
        controls.SetActive(false);
        unusedAssets.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("PlainsEasy");
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
    public void Unused()
    {
        if (unusedAssets.activeInHierarchy)
            unusedAssets.SetActive(false);
        else
            unusedAssets.SetActive(true);
    }
    public void SwitchBackground()
    {
        if (menu == 0)
        {
            TundraBackground();
            menu = 1;
        }
        else
        {
            PlainsBackground();
            menu = 0;
        }
    }
    void PlainsBackground()
    {
        Debug.Log("Setting Plains!");
        tundraObj.SetActive(false);
        plainsObj.SetActive(true);
        sign[0].SetActive(true);
        sign[1].SetActive(false);

        for (int i = 0; i < textColors.Count; i++)
        {
            Debug.Log("Setting color to grat...");
            Debug.Log(textColors[i]);
            Debug.Log(textColors[i].color);

            textColors[i].color = new Color(50f / 255f, 50f / 255f, 50f / 255f);
            Debug.Log(textColors[i].color);

        }
    }
    void TundraBackground()
    {
        Debug.Log("Setting Tundra!");
        tundraObj.SetActive(true);
        plainsObj.SetActive(false);
        sign[0].SetActive(false);
        sign[1].SetActive(true);
        for (int i = 0; i < textColors.Count; i++)
            textColors[i].color = new Color(212f / 255f, 218f / 255f, 236f / 255f);
        //textColors[i].color = new Color(165f / 255f, 181f / 255f, 231f / 255f);
    }
}
