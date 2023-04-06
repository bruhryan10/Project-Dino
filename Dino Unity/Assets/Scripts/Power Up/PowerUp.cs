using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedBoost = 2f;
    public float jumpBoost = 2f;
    public float duration = 5f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            player.moveSpeed += speedBoost;
            player.jumpSpeed+= jumpBoost;
            StartCoroutine(PowerUpTimer(player));
            Destroy(gameObject);
        }
       
    }
    IEnumerator PowerUpTimer(PlayerMovement player)
    {
        yield return new WaitForSeconds(duration);
        player.moveSpeed -= speedBoost;
        player.jumpSpeed -= jumpBoost;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
