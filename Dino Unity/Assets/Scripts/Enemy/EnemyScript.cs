using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float startTimer;
    public bool startChase;
    public GameObject Enemy;
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        startTimer = 5f;
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
        if (startChase)
        {
            Enemy.transform.position = new Vector3(transform.position.x + (6 * Time.deltaTime), transform.position.y);
        }

        
    }
}
