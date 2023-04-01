using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    void Start()
    {
        player = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        //Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
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
        if (Input.GetKeyDown(KeyCode.W) && isTouchingGround)
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

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
}
