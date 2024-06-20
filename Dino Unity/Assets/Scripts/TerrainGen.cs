using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGen : MonoBehaviour
{
    [SerializeField] PowerupSpawn powerUpSpawn;
    [SerializeField] GameObject player;
    [SerializeField] Vector2[] genPositions;
    [SerializeField] List<GameObject> plainsTerrain;
    [SerializeField] GameObject parentTerrain;
    private void Awake()
    {
        StartTerrainGen();
    }
    public void StartTerrainGen()
    {
        for (int i = 0; i < 5; i++)
        {
            int GenNum = Random.Range(1, 11);
            Debug.Log(GenNum);
            GenTerrain(GenNum, i + 1);
        }
    }
    void GenTerrain(int GenNum, int pos)
    {
        GameObject terrain = plainsTerrain[GenNum];
        GameObject spawnedTerrain = Instantiate(terrain, genPositions[pos], Quaternion.identity);
        spawnedTerrain.transform.SetParent(parentTerrain.transform);
        if (GenNum == 1 || GenNum == 2 || GenNum == 5 || GenNum == 6 || GenNum == 7 || GenNum == 9)
            powerUpSpawn.SpawnPowerup(spawnedTerrain);
    }
}
