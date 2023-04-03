using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulldozePowerUp : MonoBehaviour
{
    public float duration = 25f; 
    public float speedMultiplier = 10f; 

    private bool activated = false;

    public Animator playerAnim;

    public LayerMask groundLayer;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            activated = true;
            Destroy(gameObject);
        }
    }

   
    void Update()
    {
        if (activated)
        {
            playerAnim.Play("Triceratop New_Right");
            PlayerMovement player = FindObjectOfType<PlayerMovement>();
            player.speed *= speedMultiplier;

            
            Physics2D.IgnoreLayerCollision(player.gameObject.layer, LayerMask.NameToLayer("Obstacles"), true);

            
            Invoke("DeactivatePowerUp", duration);
        }
    }

    
    void DeactivatePowerUp()
    {
        PlayerMovement player = FindObjectOfType<PlayerMovement>();
        player.speed /= speedMultiplier;
        Physics2D.IgnoreLayerCollision(player.gameObject.layer, LayerMask.NameToLayer("Obstacles"), false);
        Destroy(gameObject);
    }

}
