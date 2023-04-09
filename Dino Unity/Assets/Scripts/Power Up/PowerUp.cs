using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedBoost = 2f;
    public float jumpBoost = 2f;
    public float duration = 5f;
    public bool startJump;
    public bool startSpeed;
    public bool startDelay;

    public GameObject powerUp;
    PlayerMovement playerMovement;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (startJump)
        {
            duration -= Time.deltaTime;
            if (duration < 0)
                endJump();
        }
        if (startSpeed)
        {
            duration -= Time.deltaTime;
            if (duration < 0)
                endSpeed();
        }
        if (startDelay)
        {
            duration -= Time.deltaTime;
            if (duration < 0)
                endDelay();
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && collision.otherCollider.tag == "Shoes")
        {
            JumpUp();
            Debug.Log("Shoes");

        }
        if (collision.gameObject.tag == "Player" && collision.otherCollider.tag == "Riding")
        {
            Debug.Log("Riding");
            SpeedUp();
        }
        if (collision.gameObject.tag == "Player" && collision.otherCollider.tag == "Meat")
        {
            Debug.Log("Meat");
            DelayEnemy();
        }
    }
    private void SpeedUp()
    {
        powerUp.transform.position = new Vector3(-66, 13);
        startSpeed = true;
        playerMovement.moveSpeed += speedBoost;
    }
    private void JumpUp()
    {
        powerUp.transform.position = new Vector3(-66, 13);
        startJump = true;
        playerMovement.jumpSpeed += jumpBoost;
    }
    private void DelayEnemy()
    {
        powerUp.transform.position = new Vector3(-66, 13);
        startDelay = true;
        playerMovement.delayEnemy = true;
    }
    private void endSpeed()
    {
        startSpeed = false;
        duration = 5f;
        playerMovement.moveSpeed -= speedBoost;
        Destroy(gameObject);
    }
    private void endJump()
    {
        startJump = false;
        duration = 5f;
        playerMovement.jumpSpeed -= jumpBoost;
        Destroy(gameObject);
    }
    private void endDelay()
    {
        startDelay = false;
        playerMovement.delayEnemy = false;
        duration = 5f;
        Destroy(gameObject);
    }
}
