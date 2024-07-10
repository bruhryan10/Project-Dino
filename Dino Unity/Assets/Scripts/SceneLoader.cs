using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] EventSystem eventSystem;
    [SerializeField] PauseUI pauseScript;
    [SerializeField] ScreenAnim animTrans;
    [SerializeField] PlainsUI painsUI;
    [SerializeField] HazardManager hazardManager;
    [SerializeField] AnimationController animCon;

    [SerializeField] Canvas pauseUI;
    [SerializeField] Canvas deathUI;
    [SerializeField] Canvas mainMenuUI;
    [SerializeField] GameObject plainsUIObj;


    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject startTrigger;
    [SerializeField] GameObject anim;
    [SerializeField] Vector2[] defaultPos;
    private void Awake()
    {
        Debug.Log("Loading Terrain...");
        SceneManager.LoadScene("Terrain", LoadSceneMode.Additive);
    }
    public void RestartCurrentScene()
    {
        StartCoroutine(animTrans.AnimatePanel());
    }
    public void AfterAnim()
    {
        Time.timeScale = 1.0f;
        StartCoroutine(ResetObjects());
    }
    IEnumerator ResetObjects()
    {
        LoadTerrain();
        eventSystem.SetSelectedGameObject(null);
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.transform.position = defaultPos[0];
        enemy.transform.position = defaultPos[1];
        enemy.SetActive(false);
        startTrigger.SetActive(true);
        enemy.GetComponent<EnemyScript>().ResetTimer();
        player.GetComponent<Collider2D>().enabled = true;
        player.GetComponent<Rigidbody2D>().gravityScale = 2.5f;
        player.GetComponent<PlayerMovement>().SetMovementStatus(false);
        animCon.ResetAnim();
        yield return new WaitForSeconds(0.02f);
        ResetUIs();

    }
    void ResetUIs()
    {
        pauseUI.enabled = false;
        deathUI.enabled = false;
        mainMenuUI.enabled = true;
        painsUI.ResetTimer(4);
        plainsUIObj.SetActive(false);
        anim.GetComponent<RectTransform>().sizeDelta = new Vector2(50, 1100);
        anim.SetActive(false);
        hazardManager.Setde();
        ResumeGame();
    }
    public void LoadTerrain()
    {
        if (SceneManager.sceneCount > 1)
        {
            SceneManager.UnloadSceneAsync("Terrain");
            SceneManager.LoadScene("Terrain", LoadSceneMode.Additive);
            Debug.Log("Terrain Scene Reloaded!");
        }
        else
            Debug.LogError("No Scene to unload!");
    }
    public void QuitGame()
    {
        Time.timeScale = 1.0f;
        Application.Quit();
    }
    public void ResumeGame()
    {
        eventSystem.SetSelectedGameObject(null);
        pauseScript.ResumeGame();
    }
}
