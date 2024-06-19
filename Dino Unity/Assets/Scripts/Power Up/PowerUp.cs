using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

  
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (playerMovement.startJump)
            Destroy(gameObject);
        if (playerMovement.startSpeed)
            Destroy(gameObject);
        if (playerMovement.startDelay)
            Destroy(gameObject);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


    }


    
}
