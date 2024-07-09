using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    PauseUI pauseUI;
    [SerializeField] ScreenAnim animTrans;
    void Start()
    {
        pauseUI = GameObject.Find("PauseUI").GetComponent<PauseUI>(); 
    }
    public void RestartCurrentScene()
    {
        StartCoroutine(animTrans.AnimatePanel());
    }
    public void AfterAnim()
    {
        Time.timeScale = 1.0f;
        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }
    public void QuitGame()
    {
        Time.timeScale = 1.0f;
        Application.Quit();
    }
    public void ResumeGame()
    {
        pauseUI.ResumeGame();
    }
}
