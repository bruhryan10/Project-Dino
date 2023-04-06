using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float speedBoost = 5f;
    public float jumpBoost = 5f;
    public float duration = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerMovement player = other.GetComponent<PlayerMovement>();
            player.moveSpeed += speedBoost;
            player.jumpHeight+= jumpBoost;
            StartCoroutine(PowerUpTimer(player));
            Destroy(gameObject);
        }
       
    }
    IEnumerator PowerUpTimer(PlayerMovement player)
    {
        yield return new WaitForSeconds(duration);
        player.moveSpeed -= speedBoost;
        player.jumpHeight -= jumpBoost;
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
