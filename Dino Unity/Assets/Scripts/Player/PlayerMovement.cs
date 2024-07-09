using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
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
    Rigidbody2D playerRB;
    [SerializeField] InputAction jumps;
    InputAction move;
    [SerializeField] PlayerInput input;
    bool stopMovement;


    void Awake()
    {
        input = GetComponent<PlayerInput>();
        jumps = input.actions.FindAction("jump");

        jumps.performed += ctx => JumpHandler();
        move = input.actions.FindAction("movement");
        //move.performed += ctx => MovementHandler();
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float MoveDir = move.ReadValue<float>();
        //Debug.Log(MoveDir);
        if (!stopMovement)
            MovementHandler(MoveDir);
        /*        if (player.transform.position.x > 676f)
                    endLevel = true;*/
    }
    void MovementHandler(float moveDir)
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");
        Jump = Vector3.zero;
        Velocity = Vector3.zero;
        //Debug.Log(direction);
        if (direction > 0f)
        {
            playerAnim.Play("DinoWalk_Right");
            playerRB.velocity = new Vector2(direction * playerStats.GetSpeed(), playerRB.velocity.y);
        }
        if (direction < 0f)
        {
            playerAnim.Play("DinoWalk_Left");
            playerRB.velocity = new Vector2(direction * playerStats.GetSpeed(), playerRB.velocity.y);
        }
    }
    void JumpHandler()
    {
        if (stopMovement)
            return;
        Debug.Log("Jump Ran!");
        if (isTouchingGround)
            playerRB.velocity = new Vector2(playerRB.velocity.x, playerStats.GetJump());
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
    void OnEnable()
    {
        if (jumps != null)
        {
            jumps.Enable();
            Debug.Log("Jump action enabled");
        }
    }

    void OnDisable()
    {
        if (jumps != null)
        {
            jumps.Disable();
            Debug.Log("Jump action disabled");
        }
    }
    public void SetMovementStatus(bool text)
    {
        stopMovement = text;
    }
}

