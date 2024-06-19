using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;
using TMPro;
using System.Linq;
public class PlayerMoveUI : MonoBehaviour
{
    Vector3 Velocity;
    Vector3 Jump;

    MainMenuUI MenuUI;
    private Rigidbody2D player;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;
    private bool isTouchingGround;
    public Animator playerAnim;
    public Vector3 moveDir;
    public float moveSpeed = 8f;
    public float jumpHeight = 5f;
    public float jumpSpeed = 5f;
    private float direction = 0f;

    void Start()
    {
        MenuUI = GameObject.Find("UIs").GetComponent<MainMenuUI>();
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
            player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
        }
        if (direction < 0f)
        {
            playerAnim.Play("DinoWalk_Left");
            player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W) && isTouchingGround || Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround)
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "StartTrigger")
        {
            MenuUI.StartGame();
        }
    }
}
