using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupSpawn : MonoBehaviour
{
    [SerializeField] List<GameObject> powerUps;
    public void SpawnPowerup(GameObject area)
    {
        powerUps.Clear();
        powerUps.Add(area.transform.Find("speed").gameObject);
        powerUps.Add(area.transform.Find("delay").gameObject);
        powerUps.Add(area.transform.Find("jump").gameObject);
        int powerNum = Random.Range(0, 3);
        //Debug.Log(powerNum);
        for (int i = 0; i < powerUps.Count; i++)
        {
            if (i == powerNum)
                powerUps[i].SetActive(true);
            else
                Destroy(powerUps[i]);
        }
    }
}
