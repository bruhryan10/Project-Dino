using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using System;
public class MainMenuScript : MonoBehaviour
{
    public Vector3 moveDir;
    public float moveSpeed = 8f;
    public float jumpHeight = 5f;
    public float jumpSpeed = 5f;
    private float direction = 0f;
    Vector3 Velocity;
    Vector3 Jump;
    private Rigidbody2D player;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    public Animator playerAnim;

    public Canvas Menu;
    public UnityEngine.UI.Image CreditsIMG;
    public UnityEngine.UI.Image ControlsIMG;


    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        CreditsIMG.enabled = false;
        ControlsIMG.enabled = false;
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
            player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.W) && isTouchingGround || Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround)
        {

            player.velocity = new Vector2(player.velocity.x, jumpSpeed);

        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void loadGame()
    {
        SceneManager.LoadScene("Plains1");
    }

    public void Credits()
    {
        if (ControlsIMG.IsActive())
        {
            ControlsIMG.enabled = false;
        }
        CreditsIMG.enabled = !CreditsIMG.IsActive();
    }
    public void Controls()
    {
        if (CreditsIMG.IsActive())
        {
            CreditsIMG.enabled = false;
        }
        ControlsIMG.enabled = !ControlsIMG.IsActive();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
