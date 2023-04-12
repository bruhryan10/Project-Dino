using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    public GameObject Enemy;
    PlayerMovement playerMovement;
    public bool startChase;
    public float startTimer = 5;
    public float easySpeed = 6;
    public float hardSpeed = 8;
    public float freeplaySpeed = 0f;
    void Start()
    {
        hardSpeed = 8;
        easySpeed = 6;
        startTimer = 5;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (playerMovement.delayEnemy)
            return;
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
            startChase = true;
        if (startChase && SceneManager.GetActiveScene().name == "PlainsEasy")
            Enemy.transform.position = new Vector3(transform.position.x + (easySpeed * Time.deltaTime), transform.position.y);
        if (startChase && SceneManager.GetActiveScene().name == "PlainsHard")
            Enemy.transform.position = new Vector3(transform.position.x + (hardSpeed * Time.deltaTime), transform.position.y);
        if (startChase && SceneManager.GetActiveScene().name == "PlainsFreePlay")
            Enemy.transform.position = new Vector3(transform.position.x + (freeplaySpeed * Time.deltaTime), transform.position.y);
        if (startChase && SceneManager.GetActiveScene().name == "TundraEasy")
            Enemy.transform.position = new Vector3(transform.position.x + (easySpeed * Time.deltaTime), transform.position.y);
        if (startChase && SceneManager.GetActiveScene().name == "TundraHard")
            Enemy.transform.position = new Vector3(transform.position.x + (hardSpeed * Time.deltaTime), transform.position.y);
        if (startChase && SceneManager.GetActiveScene().name == "TundraFreePlay")
            Enemy.transform.position = new Vector3(transform.position.x + (freeplaySpeed * Time.deltaTime), transform.position.y);
    }
}
