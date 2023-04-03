using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
    private bool inTar;
    public float tarTime;
    public float tarLimit;
    public GameObject Player;



    public Animator playerAnim;


    public int maxHealth = 1;
    public int currentHealth;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
      
        currentHealth = maxHealth;

    }

    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);
        //Uncomment when ready to test, this blocks the camera from going backwards which will be a wall and it would look weird if you couldnt go left and there was grass lol
        //if (player.transform.position.x > 0.94f) 
        //{
        //    Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);

        //}
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
        direction = Input.GetAxis("Horizontal");

        Jump = Vector3.zero;
        Velocity = Vector3.zero;
        if (direction > 0f)
        {
            playerAnim.Play("DinoWalk_Right");
            player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
            //Velocity += Vector3.right;
        }
        if (direction < 0f)
        {
            player.velocity = new Vector2(direction * moveSpeed, player.velocity.y);
            //Velocity += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.W) && isTouchingGround)
        {

            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            //Jump += Vector3.up;
            
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
            moveSpeed -= 2;
            inTar = true;
        }
        if(collision.collider.tag == "KillBox")
        {
            Die();
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
            moveSpeed += 2;
            inTar = false;
            tarTime = 0;
        }
    }

    public void TarPitTimer()
    {
        if(tarTime > tarLimit)
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<Rigidbody2D>().gravityScale = 0.1f;
            StartCoroutine(TarFalling());
            
        }
        else
        {
            tarTime += Time.deltaTime;
        }
    }
    IEnumerator TarFalling()
    {
        
        yield return new WaitForSecondsRealtime(2);
        Die();

    }

    public void Die()
    {
        Debug.Log("Death");
        //death UI code here
        //Destroy(gameObject); commented for testing purposes
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
    }




    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        if (currentHealth <= 0)
        {
            Death();
            Debug.Log("Player is dead!");
        }
    }

    void Death()
    {
     
    }

}

