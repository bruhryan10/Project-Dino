using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float startTimer;
    public bool startChase;
    public GameObject Enemy;
    void Start()
    {
        startTimer = 5f;
    }

    void Update()
    {
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
        {
            startChase = true;
        }
        if (startChase)
        {
            Enemy.transform.position = new Vector3(transform.position.x + (7 * Time.deltaTime), transform.position.y);
        }

        
    }
}
