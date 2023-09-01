using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    Vector3 Velocity;
    Vector3 Jump;
    public GameObject Player;
    public Animator playerAnim;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;
    [HideInInspector]
    public Vector3 moveDir;
    public float moveSpeed = 7f;
    public float jumpSpeed = 5f;
    private float direction = 0f;
    private Rigidbody2D player;
    private bool inTar;
    public float tarTime;
    public float tarLimit;
    [HideInInspector]
    public bool isDead;
    [HideInInspector]
    public bool isDying;
    public bool delayEnemy;
    [HideInInspector]
    public bool endLevel;
    public float speedBoost = 2f;
    public float jumpBoost = 2f;
    public float duration = 5f;
    [HideInInspector]
    public bool startJump;
    [HideInInspector]
    public bool startSpeed;
    [HideInInspector]
    public bool startDelay;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        endLevel = false;
        isDying = false;
    }

    void Update()
    {
        if (player.transform.position.x > -3.1f && player.transform.position.x !< 668f && !isDying)
            Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");

        Jump = Vector3.zero;
        Velocity = Vector3.zero;
        if(!inTar && !isDead && !isDying)
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

            if (direction > 0f)
            {
                player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
                //if (startSpeed)
                //    playerAnim.Play("Dino_wheel");
                //else
                //    playerAnim.Play("Dino_wheel");
                playerAnim.Play("DinoWalk_Right");
            }
            if (direction < 0f)
            {
                playerAnim.Play("DinoWalk_Left");
                player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
            }
            if (Input.GetKeyDown(KeyCode.W) && isTouchingGround || Input.GetKeyDown(KeyCode.UpArrow) && isTouchingGround)
                player.velocity = new Vector2(player.velocity.x, jumpSpeed);
           
            if (player.transform.position.x > 676f)
                endLevel = true;
        }





    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Icicle")
        {
            Die();
        }
        if(collision.collider.tag == "TarPit")
        {
            moveSpeed -= 3;
        }

        if (collision.gameObject.tag == "Shoes")
        {
            JumpUp();
            Debug.Log("Shoes");

        }
        if (collision.gameObject.tag == "Riding")
        {

            Debug.Log("Riding");
            SpeedUp();
        }
        if (collision.gameObject.tag == "Meat")
        {
            Debug.Log("Meat");
            DelayEnemy();
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.collider.tag == "TarPit")
        {
            TarPitTimer();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.collider.tag == "TarPit")
        {
            moveSpeed += 3;
            tarTime = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
            Die();
        if(collision.tag == "Water")
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 0.2f;
            StartCoroutine(TarFalling());
        }
        if(collision.tag == "KillBox")
            StartCoroutine(TarFalling());
    }

    public void TarPitTimer()
    {
        if(tarTime > tarLimit)
        {
            inTar = true;
            GetComponent<Collider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            StartCoroutine(TarFalling());
            
        }
        else
            tarTime += Time.deltaTime;
    }
    IEnumerator TarFalling()
    {
        isDying = true;
        yield return new WaitForSecondsRealtime(2);
        Die();

    }

    public void Die()
    {
        isDead = true;
        Debug.Log("Death");
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }
    public void SpeedUp()
    {
        startSpeed = true;
        moveSpeed += speedBoost;
    }
    public void JumpUp()
    {
        startJump = true;
        jumpSpeed += jumpBoost;
    }
    public void DelayEnemy()
    {
        startDelay = true;
        delayEnemy = true;
    }
    private void endSpeed()
    {
        startSpeed = false;
        duration = 5f;
        moveSpeed -= speedBoost;
    }
    private void endJump()
    {
        startJump = false;
        duration = 5f;
        jumpSpeed -= jumpBoost;
    }
    private void endDelay()
    {
        startDelay = false;
        delayEnemy = false;
        duration = 5f;
    }
}

