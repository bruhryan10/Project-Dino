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
    public GameObject speedUp;
    public GameObject jumpUp;
    public GameObject delayUp;
    public GameObject player;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject Enemy4;
    public GameObject Enemy5;
    public GameObject Enemy6;
    public GameObject Enemy7;

    public bool debugEnabled;
    public bool enemyToggle;
    public TMP_Text debugMessage;
    void Start()
    {
        terrain = GameObject.Find("Player").GetComponent<RandomTerrainPlains>();
        debugEnabled = false;
        debugMessage.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            DebuggerStart();
        }
        if (debugEnabled)
        {
            debugMessage.enabled = true;
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
            if (Input.GetKeyDown(KeyCode.BackQuote))
                SceneManager.LoadScene("Main Menu");
            if (Input.GetKeyDown(KeyCode.Alpha1))
                SceneManager.LoadScene("PlainsEasy");
            if (Input.GetKeyDown(KeyCode.Alpha2))
                SceneManager.LoadScene("PlainsHard");
            if (Input.GetKeyDown(KeyCode.Alpha3))
                SceneManager.LoadScene("TundraEasy");
            if (Input.GetKeyDown(KeyCode.Alpha4))
                SceneManager.LoadScene("TundraHard");
            if (Input.GetKeyDown(KeyCode.Alpha5))
                Instantiate(speedUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.Alpha6))
                Instantiate(jumpUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.Alpha7))
                Instantiate(delayUp).transform.position = new Vector2(player.transform.position.x + 2, player.transform.position.y);
            if (Input.GetKeyDown(KeyCode.E))
                EnemyToggler();
        }
    }
    private void DebuggerStart()
    {
        debugEnabled = !debugEnabled;
        if (debugMessage.enabled == true)
        {
            debugMessage.enabled = false;
        }
    }
    private void EnemyToggler()
    {
        enemyToggle = !enemyToggle;
        if (enemyToggle)
        {
            Enemy.SetActive(false);
            Enemy2.SetActive(false);
            Enemy3.SetActive(false);
            Enemy4.SetActive(false);
            Enemy5.SetActive(false);
            Enemy6.SetActive(false);
            Enemy7.SetActive(false);
        }
        if (!enemyToggle)
        {
            Enemy.SetActive(true);
            Enemy2.SetActive(true);
            Enemy3.SetActive(true);
            Enemy4.SetActive(true);
            Enemy5.SetActive(true);
            Enemy6.SetActive(true);
            Enemy7.SetActive(true);
        }
    }
    private void F1()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneOne();
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F2()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneTwo();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F3()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneThree();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F4()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneFour();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F5()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneFive();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F6()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneOneV();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F7()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneTwoV();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F8()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneThreeV();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F9()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneFourV();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFiveV.SetActive(false);
    }
    private void F10()
    {
        terrain.loadArea1 = false;
        terrain.loadArea2 = true;
        terrain.LoadAreaOneFiveV();
        terrain.AreaOneOne.SetActive(false);
        terrain.AreaOneTwo.SetActive(false);
        terrain.AreaOneThree.SetActive(false);
        terrain.AreaOneFour.SetActive(false);
        terrain.AreaOneFive.SetActive(false);
        terrain.AreaOneOneV.SetActive(false);
        terrain.AreaOneTwoV.SetActive(false);
        terrain.AreaOneThreeV.SetActive(false);
        terrain.AreaOneFourV.SetActive(false);
    }
}