using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;


    Vector3 Velocity;
    Vector3 Jump;
    [SerializeField] GameObject Player;
    [SerializeField] Animator playerAnim;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;
    bool isTouchingGround;
    [SerializeField] Vector3 moveDir;
    [SerializeField] float direction = 0f;
    Rigidbody2D player;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");

        Jump = Vector3.zero;
        Velocity = Vector3.zero;
        if (direction > 0f)
        {
            playerAnim.Play("DinoWalk_Right");
            player.velocity = new Vector2(direction * playerStats.GetSpeed(), player.velocity.y);
        }
        if (direction < 0f)
        {
            playerAnim.Play("DinoWalk_Left");
            player.velocity = new Vector2(direction * playerStats.GetSpeed(), player.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W) && isTouchingGround || Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround)
            player.velocity = new Vector2(player.velocity.x, playerStats.GetJump());

/*        if (player.transform.position.x > 676f)
            endLevel = true;*/
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}

