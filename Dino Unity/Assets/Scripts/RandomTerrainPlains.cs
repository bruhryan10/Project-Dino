using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomTerrainPlains : MonoBehaviour
{
    public GameObject player;
    public GameObject Plains2;
    public GameObject Plains2Copy;
    public GameObject Plains3;
    public GameObject Plains3Copy;
    public float areaToLoad;
    public bool loadArea2;
    public bool loadArea3;
    public bool loadArea4;
    void Start()
    {
        Plains2.SetActive(false);
        Plains3.SetActive(false);
        Plains2Copy.SetActive(false);
        Plains3Copy.SetActive(false);
        loadArea2 = true;
    }

    void Update()
    {
        if (player.transform.position.x > 8 && loadArea2 == true)
        {
            areaToLoad = Random.Range(1, 3);
            Debug.Log(areaToLoad);
            if (areaToLoad == 1)
            {
                Plains2.SetActive(true);
                loadArea2 = false;
                loadArea3 = true;
            }
            if (areaToLoad == 2)
            {
                Plains3.SetActive(true);
                Plains3.transform.position = new Vector3(-24, 0);
                loadArea2 = false;
                loadArea3 = true;
            }
        }
        if (player.transform.position.x > 30 && loadArea3 == true)
        {
            areaToLoad = Random.Range(1, 3);
            Debug.Log(areaToLoad);
            if (areaToLoad == 1)
            {
                Plains2Copy.SetActive(true);
                Plains2Copy.transform.position = new Vector3(23, -2);
                loadArea3 = false;
                loadArea4 = true;
            }
            if (areaToLoad == 2)
            {
                Plains3Copy.SetActive(true);
                Plains3Copy.transform.position = new Vector3(0, -2);
                loadArea3 = false;
                loadArea4 = true;
            }
        }



        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("Plains1");
        }
    }
}
