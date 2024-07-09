using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] AnimationController anim;

    [SerializeField] GameObject Player;
    [SerializeField] Transform groundCheck;
    [SerializeField] float groundCheckRadius;
    [SerializeField] LayerMask groundLayer;
    bool isTouchingGround;
    [SerializeField] Vector3 moveDir;
    [SerializeField] Rigidbody2D playerRB;
    bool stopMovement;


    [SerializeField] float acceleration;
    [SerializeField] float deceleration;
    float currentSpeed;
    float previousMoveDir;
    float MoveDir;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        playerRB = GetComponent<Rigidbody2D>();
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
    }
    public void MovementHandler(float moveDir)
    {
        if (stopMovement)
            return;
        if (moveDir != previousMoveDir && moveDir != 0)
            currentSpeed = 0f;
        if (moveDir != 0)
        {
            currentSpeed += acceleration * Time.deltaTime;
            currentSpeed = Mathf.Min(currentSpeed, playerStats.GetSpeed());
        }
        else
            currentSpeed = 0f;
        if (moveDir > 0f)
            playerRB.velocity = new Vector2(moveDir * currentSpeed, playerRB.velocity.y);
        else if (moveDir < 0f)
            playerRB.velocity = new Vector2(moveDir * currentSpeed, playerRB.velocity.y);
        else
            playerRB.velocity = new Vector2(playerRB.velocity.x * (1 - deceleration * Time.deltaTime), playerRB.velocity.y);
        float velocity = playerRB.velocity.x;
        anim.AnimMove(moveDir, velocity);
        previousMoveDir = moveDir;
    }
    public void JumpHandler(float moveDir)
    {
        if (stopMovement)
            return;
        if (isTouchingGround)
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, playerStats.GetJump());
            anim.AnimJump(moveDir);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
    public void SetMovementStatus(bool text)
    {
        stopMovement = text;
    }
}

