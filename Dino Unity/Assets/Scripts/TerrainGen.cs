using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class TerrainGen : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] GameObject speedPower;
    [SerializeField] GameObject delayPower;
    [SerializeField] GameObject jumpPower;
    int powerNum;
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
    void GenTerrain(int num, int pos)
    {
        GameObject terrain = plainsTerrain[num];
        GameObject spawnedTerrain = Instantiate(terrain, genPositions[pos], Quaternion.identity);
        spawnedTerrain.transform.SetParent(parentTerrain.transform);
    }
}
