using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEditor.TerrainTools;

public class Debugger : MonoBehaviour
{
    TerrainGen terrainGen;

    public GameObject speedUp;
    public GameObject jumpUp;
    public GameObject delayUp;
    public GameObject player;
    public GameObject Enemy;

    public bool debugEnabled;
    public bool enemyToggle;
    bool enemyColl;
    public GameObject debugstuff;
    Rigidbody2D rb;
    [SerializeField] List<GameObject> terrainObjs;
    bool terrainShowcase;
    GameObject TerrainShowcaseSpawned;
    Vector2 storedPos;
    void Start()
    {
        terrainGen = GameObject.Find("TerrainGenManager").GetComponent<TerrainGen>();
        debugEnabled = false;
        debugstuff.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            DebuggerStart();
        if (!debugEnabled)
            return;
        for (int i = 1; i <= 10; i++)
            if (Input.GetKeyDown("f" + i))
                TerrainShowcase(i);
        debugstuff.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Tab) && terrainShowcase)
        {
            terrainShowcase = false;
            Destroy(TerrainShowcaseSpawned);
            player.transform.position = storedPos;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SceneManager.LoadScene("PlainsEasy");
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SceneManager.LoadScene("TundraEasy");
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject spawn = Instantiate(speedUp);
            spawn.transform.position = new Vector2(player.transform.position.x + 2.5f, player.transform.position.y);
            spawn.name = speedUp.name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GameObject spawn = Instantiate(jumpUp);
            spawn.transform.position = new Vector2(player.transform.position.x + 2.5f, player.transform.position.y);
            spawn.name = jumpUp.name;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GameObject spawn = Instantiate(delayUp);
            spawn.transform.position = new Vector2(player.transform.position.x + 2.5f, player.transform.position.y);
            spawn.name = delayUp.name;
        }
        if (Input.GetKeyDown(KeyCode.E))
            EnemyToggler();
        if (Input.GetKeyDown(KeyCode.C))
            EnemyCollision();
        if (Input.GetKeyDown(KeyCode.K))
            player.GetComponent<DeathScript>().PlayerDeath();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach (Transform child in terrainGen.transform)
                Destroy(child.gameObject);
            terrainGen.StartTerrainGen();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 3);
        if (Input.GetKeyDown(KeyCode.DownArrow))
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 3);
        if (Input.GetKeyDown(KeyCode.RightArrow))
            player.transform.position = new Vector2(player.transform.position.x + 3, player.transform.position.y);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            player.transform.position = new Vector2(player.transform.position.x - 3, player.transform.position.y);
    }
    private void DebuggerStart()
    {
        debugEnabled = !debugEnabled;
        if (debugstuff.activeInHierarchy)
        {
            debugstuff.SetActive(false);
        }
    }
    void EnemyCollision()
    {
        enemyColl = !enemyColl;
        if (enemyColl)
        {
            Enemy.GetComponent<EnemyScript>().SetDelay(true);
            Enemy.GetComponent<BoxCollider2D>().enabled = false;
        }
        else
        {
            Enemy.GetComponent<EnemyScript>().SetDelay(false);
            Enemy.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    private void EnemyToggler()
    {
        enemyToggle = !enemyToggle;
        if (enemyToggle)
            Enemy.SetActive(false);
        if (!enemyToggle)
            Enemy.SetActive(true);
    }
    void TerrainShowcase(int terrain)
    {
        if (!terrainShowcase)
            storedPos = player.transform.position;
        terrainShowcase = true;
        Destroy(TerrainShowcaseSpawned);
        TerrainShowcaseSpawned = Instantiate(terrainObjs[terrain]);
        TerrainShowcaseSpawned.transform.position = new Vector2(0, 130);
        transform.position = new Vector2(0, 100);
        Debug.Log("Loading Terrain " + terrain + "(" + TerrainShowcaseSpawned.name + ")");
    }
}
