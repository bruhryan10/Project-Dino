using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;
using TMPro;
using UnityEditor.TerrainTools;
using UnityEngine.InputSystem;

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
    public GameObject debugUI;
    Rigidbody2D rb;
    [SerializeField] List<GameObject> terrainObjs;
    bool terrainShowcase;
    GameObject TerrainShowcaseSpawned;
    Vector2 storedPos;

    [SerializeField] TMP_Text debuggerHeader;
    [SerializeField] TMP_Text generalLeft;
    [SerializeField] TMP_Text generalRight;
    [SerializeField] TMP_Text cameraText;
    [SerializeField] TMP_Text previewText;
    [SerializeField] bool camToggle;
    [SerializeField] Camera mainCam;
    Vector3 camLoc;
    [SerializeField] float camSpeed;
    [SerializeField] float zoomSpeed = 1.0f;
    string headerText;


    void Start()
    {
        terrainGen = GameObject.Find("TerrainGenManager").GetComponent<TerrainGen>();
        debugEnabled = false;
        previewText.enabled = false;
        cameraText.enabled = false;
        debugUI.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
            DebuggerStart();
        if (!debugEnabled)
            return;
        debugUI.SetActive(true);
        for (int i = 1; i <= 10; i++)
            if (Input.GetKeyDown("f" + i))
                TerrainShowcase(i);
        if (terrainShowcase)
        {
            debuggerHeader.text = "Debugger - Terrain Preview";
            generalLeft.enabled = false;
            generalRight.enabled = false;
            previewText.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab) && terrainShowcase)
            DisableTerrainShowcase();
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
        if (Input.GetKeyDown(KeyCode.Q))
            EnemyCollision();
        if (Input.GetKeyDown(KeyCode.K))
            player.GetComponent<DeathScript>().PlayerDeath();
        if (Input.GetKeyDown(KeyCode.Z))
        {
            foreach (Transform child in terrainGen.transform)
                Destroy(child.gameObject);
            terrainGen.StartTerrainGen();
        }
        if (Input.GetKeyDown(KeyCode.C))
            CameraToggle();
        if (camToggle)
            CamMovement();
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
        if (debugUI.activeInHierarchy)
            debugUI.SetActive(false);
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
    void CamMovement()
    {
        camSpeed = 10 * (mainCam.orthographicSize * 0.33f);
        Vector3 newPosition = mainCam.transform.position;
        if (Input.GetKey(KeyCode.W))
            newPosition.y += camSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            newPosition.y -= camSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            newPosition.x += camSpeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            newPosition.x -= camSpeed * Time.deltaTime;
        newPosition.z = -10;
        mainCam.transform.position = newPosition;
        if (Mouse.current.scroll.ReadValue().y > 0)
            mainCam.orthographicSize = Mathf.Max(mainCam.orthographicSize - zoomSpeed);
        if (Mouse.current.scroll.ReadValue().y < 0)
            mainCam.orthographicSize = Mathf.Max(mainCam.orthographicSize + zoomSpeed);
    }
    void CameraToggle()
    {
        camToggle = !camToggle;
        Debug.Log("Toggled Cam!");
        if (!camToggle)
        {
            player.GetComponent<PlayerMovement>().SetMovementStatus(false);
            mainCam.transform.localPosition = new Vector3(-0.03000021f,1,-10);
            mainCam.orthographicSize = 4.25f;
            cameraText.enabled = false;
            generalLeft.enabled = true;
            generalRight.enabled = true;
        }
        else
        {
            camLoc = mainCam.transform.position;
            player.GetComponent<PlayerMovement>().SetMovementStatus(true);
            debuggerHeader.text = "Debugger - Camera Move";
            cameraText.enabled = true;
            generalLeft.enabled = false;
            generalRight.enabled = false;
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
    void DisableTerrainShowcase()
    {
        debuggerHeader.text = "Debugger - General";
        terrainShowcase = false;
        Destroy(TerrainShowcaseSpawned);
        player.transform.position = storedPos;
        generalLeft.enabled = true;
        generalRight.enabled = true;
        previewText.enabled = false;
    }
}
