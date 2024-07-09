using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject Enemy;
    bool startChase;
    [SerializeField] bool delay;
    [SerializeField] float startTimer;
    [SerializeField] int enemySpeed;

    void Update()
    {
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
            startChase = true;
        if (startChase && !delay)
            Enemy.transform.position = new Vector3(transform.position.x + (enemySpeed * Time.deltaTime), player.transform.position.y);
    }
    public void SetDelay(bool text)
    {
        delay = text;
    }
    public void ResetTimer()
    {
        startTimer = 5;
    }
}
