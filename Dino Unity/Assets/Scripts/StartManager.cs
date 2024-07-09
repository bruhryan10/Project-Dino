using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    [SerializeField] Canvas MainMenuUI;
    [SerializeField] GameObject PlainsUI;
    [SerializeField] GameObject start;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject terrainGenManager;
    [SerializeField] GameObject colliderObj;
    public void StartGame()
    {
        MainMenuUI.enabled = false;
        colliderObj.SetActive(false);
        start.SetActive(true);
        PlainsUI.SetActive(true);
        enemy.SetActive(true);
        //terrainGenManager.SetActive(true);
        Debug.Log("Game Started!");
    }
}
