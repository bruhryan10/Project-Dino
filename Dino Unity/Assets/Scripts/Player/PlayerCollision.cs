using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] StartManager start;
    [SerializeField] PowerManager powerManager;
    [SerializeField] PlayerStats playerStats;
    [SerializeField] HazardManager hazardManager;
    [SerializeField] DeathScript death;
    [SerializeReference] sc scs;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "StartTrigger")
            start.StartGame();
        if (other.tag == "PowerUp")
            powerManager.StartPowerUp(other.gameObject);
        if (other.tag == "Enemy")
            death.PlayerDeath();
        if (other.tag == "skull_crusher")
            StartCoroutine(scs.Yep());
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "TarPit")
            hazardManager.TarDebuff(-3);
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.collider.tag == "TarPit")
        {
            hazardManager.TarDebuff(3);
            hazardManager.ResetTimer();
        }
    }
    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.collider.tag == "TarPit")
        {
            hazardManager.StartTimer();
        }
    }
}
