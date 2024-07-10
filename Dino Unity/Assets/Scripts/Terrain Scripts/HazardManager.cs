using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardManager : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] DeathScript death;
    [SerializeField] GameObject player;
    [SerializeField] float tarTime;
    [SerializeField] float tarLimit;
    [SerializeField] public bool de;
    public void TarDebuff(int num)
    {
        playerStats.SetSpeed(num);
    }
    public void ResetTimer()
    {
        tarTime = 0;
    }
    public void Setde()
    {
        de = false;
    }
    public void StartTimer()
    {
        if (tarTime > tarLimit && !de)
        {
            de = true;
            StartCoroutine(TarDeath());

        }
        else
            tarTime += Time.deltaTime;
    }
    IEnumerator TarDeath()
    {
        player.GetComponent<PlayerMovement>().SetMovementStatus(true);
        player.GetComponent<Collider2D>().enabled = false;
        player.GetComponent<Rigidbody2D>().gravityScale = 0.1f;
        yield return new WaitForSeconds(2);
        death.PlayerDeath();
    }
}
