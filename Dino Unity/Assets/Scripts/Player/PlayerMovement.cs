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

    void Awake()
    {
        input = GetComponent<PlayerInput>();
        if (input == null)
        {
            Debug.LogError("PlayerInput component not found!");
            return;
        }

        jumps = input.actions.FindAction("HE");
        if (jumps == null)
        {
            Debug.LogError("Input action 'HE' not found!");
            return;
        }

        //jumps.performed += ctx => JumpHandler();
        Debug.Log("Subscribed to jumps.performed");
        //move = input.actions.FindActionMap("Movement").FindAction("move");
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MovementHandler();
        jumps.performed += ctx => Debug.Log("Pressed!");

        /*        if (player.transform.position.x > 676f)
                    endLevel = true;*/
    }
    void MovementHandler()
    {
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");
        Jump = Vector3.zero;
        Velocity = Vector3.zero;
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
}

