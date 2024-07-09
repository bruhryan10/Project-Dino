using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] PauseUI pauseScript;
    [SerializeField] ScreenAnim animTrans;
    [SerializeField] PlainsUI painsUI;

    [SerializeField] Canvas pauseUI;
    [SerializeField] Canvas deathUI;
    [SerializeField] Canvas mainMenuUI;
    [SerializeField] GameObject plainsUIObj;


    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject startTrigger;
    [SerializeField] GameObject anim;
    [SerializeField] Vector2[] defaultPos;
    public void RestartCurrentScene()
    {
        StartCoroutine(animTrans.AnimatePanel());
    }
    public void AfterAnim()
    {
        Time.timeScale = 1.0f;
        ResetObjects();
/*        string currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);*/
    }
    void ResetObjects()
    {
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.transform.position = defaultPos[0];
        enemy.transform.position = defaultPos[1];
        anim.SetActive(false);
        enemy.SetActive(false);
        startTrigger.SetActive(true);
        anim.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 1100);
        anim.SetActive(false);
        enemy.GetComponent<EnemyScript>().ResetTimer();
        player.GetComponent<Collider2D>().enabled = true;
        player.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
        player.GetComponent<PlayerMovement>().SetMovementStatus(false);
        ResetUIs();

        LoadTerrain();
    }
    void ResetUIs()
    {
        pauseUI.enabled = false;
        deathUI.enabled = false;
        mainMenuUI.enabled = true;
        painsUI.ResetTimer(4);
        plainsUIObj.SetActive(false);
        ResumeGame();
    }
    void LoadTerrain()
    {

    }
    public void QuitGame()
    {
        Time.timeScale = 1.0f;
        Application.Quit();
    }
    public void ResumeGame()
    {
        pauseScript.ResumeGame();
    }
}
