using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    public float startTimer;
    public bool startChase;
    public GameObject Enemy;
    public float easySpeed;
    public float hardSpeed;
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        startTimer = 5f;
        easySpeed = 6;
        hardSpeed = 8;
    }

    void Update()
    {
        if (playerMovement.delayEnemy)
        {
            return;
        }
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
        {
            startChase = true;
        }
        if (startChase && SceneManager.GetActiveScene().name == "Plains1")
        {
            Enemy.transform.position = new Vector3(transform.position.x + (easySpeed * Time.deltaTime), transform.position.y);
        }
        if (startChase && SceneManager.GetActiveScene().name == "PlainsHard")
        {
            Enemy.transform.position = new Vector3(transform.position.x + (hardSpeed * Time.deltaTime), transform.position.y);
        }


    }
}
