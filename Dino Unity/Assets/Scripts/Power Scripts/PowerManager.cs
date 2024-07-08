using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public class PowerManager : MonoBehaviour
{
    [SerializeField] PlayerStats playerStats;
    [SerializeField] EnemyScript enemyScript;

    public void StartPowerUp(GameObject powerObject)
    {
        if (powerObject.name == "delay")
            StartCoroutine(DelayPower());
        if (powerObject.name == "speed")
            StartCoroutine(SpeedPower());
        if (powerObject.name == "jump")
            StartCoroutine(JumpPower());
        Destroy(powerObject);
    }
    IEnumerator DelayPower()
    {
        enemyScript.SetDelay(true);
        yield return new WaitForSeconds(4f);
        enemyScript.SetDelay(false);
    }
    IEnumerator SpeedPower()
    {
        playerStats.SetSpeed(2);
        yield return new WaitForSeconds(5f);
        playerStats.SetSpeed(-2);
    }
    IEnumerator JumpPower()
    {
        playerStats.SetJump(2);
        yield return new WaitForSeconds(5f);
        playerStats.SetJump(-2);
    }
}
