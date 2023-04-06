using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{

    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;

    private Transform player;
    private Rigidbody2D rb;
    private bool isGrounded;

    PlayerMovement playerMovement;
    public int Damage = 1;
    
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        player = GameObject.FindWithTag("Player").transform;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {

        float distanceToPlayer = Vector2.Distance(transform.position, player.position);


        if (distanceToPlayer < 10f)
        {

            if (player.position.x < transform.position.x)
            {
                rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            }

            else if (player.position.x > transform.position.x)
            {
                rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            }


            isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);


            if (isGrounded)
            {
                rb.AddForce(new Vector2(0f, jumpForce));
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with the player
        if (collision.gameObject.CompareTag("Player"))
        {
            playerMovement.Die();
            // Reduce the player's health by the damage amount
            //PlayerMovement playerHealth = collision.gameObject.GetComponent<PlayerMovement>();
            //if (playerHealth != null)
            //{
            //    playerHealth.TakeDamage(Damage);

            //    Destroy(collision.gameObject);
            //    Debug.Log("Player got stomped");
            //}
        }

    }
}