using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;

public class Debugger : MonoBehaviour
{
    RandomTerrainPlains terrain;
    TerrainGen terrainGen;
    PlayerMovement playerMovement;

    public GameObject speedUp;
    public GameObject jumpUp;
    public GameObject delayUp;
    public GameObject player;
    public GameObject Enemy;

    public bool debugEnabled;
    public bool enemyToggle;
    public GameObject debugstuff;
    Rigidbody2D rb;
    void Start()
    {
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        terrain = GameObject.Find("Player").GetComponent<RandomTerrainPlains>();
        terrainGen = GameObject.Find("TerrainGenManager").GetComponent<TerrainGen>();
        debugEnabled = false;
        debugstuff.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DebuggerStart();
        }
        if (debugEnabled)
        {
            debugstuff.SetActive(true);
            if (Input.GetKeyDown(KeyCode.F1))
                F1();
            if (Input.GetKeyDown(KeyCode.F2))
                F2();
            if (Input.GetKeyDown(KeyCode.F3))
                F3();
            if (Input.GetKeyDown(KeyCode.F4))
                F4();
            if (Input.GetKeyDown(KeyCode.F5))
                F5();
            if (Input.GetKeyDown(KeyCode.F6))
                F6();
            if (Input.GetKeyDown(KeyCode.F7))
                F7();
            if (Input.GetKeyDown(KeyCode.F8))
                F8();
            if (Input.GetKeyDown(KeyCode.F9))
                F9();
            if (Input.GetKeyDown(KeyCode.F10))
                F10();
            if (Input.GetKeyDown(KeyCode.Alpha1))
                SceneManager.LoadScene("Main Menu");
            if (Input.GetKeyDown(KeyCode.Alpha2))
                SceneManager.LoadScene("PlainsEasy");
            if (Input.GetKeyDown(KeyCode.Alpha3))
                SceneManager.LoadScene("TundraEasy");
            if (Input.GetKeyDown(KeyCode.Alpha4))
                Instantiate(speedUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.Alpha5))
                Instantiate(jumpUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.Alpha6))
                Instantiate(delayUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.E))
                EnemyToggler();
            if (Input.GetKeyDown(KeyCode.UpArrow))
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y + 3);
            if (Input.GetKeyDown(KeyCode.DownArrow))
                player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y - 3);
            if (Input.GetKeyDown(KeyCode.RightArrow))
                player.transform.position = new Vector2(player.transform.position.x + 3, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                player.transform.position = new Vector2(player.transform.position.x - 3, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.R))
                SceneManager.LoadScene("PlainsEasy");
<<<<<<< Updated upstream
=======
            if (Input.GetKeyDown(KeyCode.K))
                playerMovement.isDead = true;
            if (Input.GetKeyDown(KeyCode.Z))
            {
                foreach (Transform child in terrainGen.transform)
                    Destroy(child.gameObject);
                terrainGen.StartTerrainGen();
            }
>>>>>>> Stashed changes
        }
    }
    private void DebuggerStart()
    {
        debugEnabled = !debugEnabled;
        if (debugstuff.activeInHierarchy)
        {
            debugstuff.SetActive(false);
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
    private void F1()
    {
        terrain.loadNumber = 1;
        terrain.LoadAreaOne();
    }
    private void F2()
    {
        terrain.loadNumber = 2;
        terrain.LoadAreaOne();
    }
    private void F3()
    {
        terrain.loadNumber = 3;
        terrain.LoadAreaOne();
    }
    private void F4()
    {
        terrain.loadNumber = 4;
        terrain.LoadAreaOne();
    }
    private void F5()
    {
        terrain.loadNumber = 5;
        terrain.LoadAreaOne();
    }
    private void F6()
    {
        terrain.loadNumber = 6;
        terrain.LoadAreaOne();
    }
    private void F7()
    {
        terrain.loadNumber = 7;
        terrain.LoadAreaOne();
    }
    private void F8()
    {
        terrain.loadNumber = 8;
        terrain.LoadAreaOne();
    }
    private void F9()
    {
        terrain.loadNumber = 9;
        terrain.LoadAreaOne();
    }
    private void F10()
    {
        terrain.loadNumber = 10;
        terrain.LoadAreaOne();
    }
}
