using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestLoadMenu : MonoBehaviour
{
    MainMenuUI MenuUI;
    RandomTerrainPlains terrain;
    DeathScript death;
    Debugger debug;


    private void Awake()
    {
        MenuUI = GameObject.Find("UIs").GetComponent<MainMenuUI>();
        terrain = this.GetComponent<RandomTerrainPlains>();
        death = this.GetComponent<DeathScript>();
        debug = this.GetComponent<Debugger>();

        terrain.enabled = false;
        death.enabled = false;
        debug.enabled = false;
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "StartTrigger")
        {
            LoadScene("PlainsEasy", "Main Menu");
            SceneManager.LoadScene("PlainsEasy");
            terrain.enabled = true;
            death.enabled = true;
            debug.enabled = true;
        }
    }
    public void LoadScene(string newSceneName, string oldSceneName)
    {
        StartCoroutine(LoadNewScene(newSceneName, oldSceneName));
    }

    private IEnumerator LoadNewScene(string newSceneName, string oldSceneName)
    {
        // Start loading the new scene
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(newSceneName, LoadSceneMode.Additive);

        // Wait until the new scene is fully loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        // Optionally set the new scene as the active scene
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(newSceneName));

        // Unload the old scene
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(oldSceneName);

        // Wait until the old scene is fully unloaded
        while (!asyncUnload.isDone)
        {
            yield return null;
        }
    }
}
