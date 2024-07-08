using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    public GameObject player;
    public GameObject Enemy;
    PlayerMovement playerMovement;
    public bool startChase;

    [SerializeField] float startTimer = 5;
    [SerializeField] int enemySpeed;
    void Start()
    {
        enemySpeed = 6;
        startTimer = 5;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
/*        if (playerMovement.delayEnemy)
            return;*/
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
            startChase = true;
        if (startChase)
            Enemy.transform.position = new Vector3(transform.position.x + (enemySpeed * Time.deltaTime), player.transform.position.y);
    }
}
