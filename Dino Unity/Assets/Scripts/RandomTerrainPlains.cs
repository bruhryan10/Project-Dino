using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomTerrainPlains : MonoBehaviour
{
    public GameObject player;

    public float powerNumber;
    public GameObject speedUp;
    public GameObject jumpUp;
    public GameObject delayUp;

    public GameObject One;
    public GameObject Two;
    public GameObject Three;
    public GameObject Four;
    public GameObject Five;
    public GameObject OneV;
    public GameObject TwoV;
    public GameObject ThreeV;
    public GameObject FourV;
    public GameObject FiveV;

    public float loadNumber;
    public bool loadArea1;
    public bool loadArea2;
    public bool loadArea3;
    public bool loadArea4;
    public bool loadArea5;

    private void Awake()
    {
       loadArea1 = true;
    }

    void Update()
    {
        if (player.transform.position.x > 66 && loadArea1 == true)
        {
            loadNumber = Random.Range(1, 11);
            LoadAreaOne();
        }
        if (player.transform.position.x > 166 && loadArea2 == true)
        {
            loadNumber = Random.Range(1, 11);
            LoadAreaTwo();
        }
        if (player.transform.position.x > 266 && loadArea3 == true)
        {
            loadNumber = Random.Range(1, 11);
            LoadAreaThree();
        }
        if (player.transform.position.x > 366 && loadArea4 == true)
        {
            loadNumber = Random.Range(1, 11);
            LoadAreaFour();
        }
        if (player.transform.position.x > 466 && loadArea5 == true)
        {
            loadNumber = Random.Range(1, 11);
            LoadAreaFive();
        }
    }
    public void LoadAreaOne()
    {

        Debug.Log(loadNumber);
        if (loadNumber == 1)
        {
            Instantiate(One).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 2)
        {
            Instantiate(Two).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 3)
        {
            Instantiate(Three).transform.position = new Vector3(89, 50);
        }
        if (loadNumber == 4)
        {
            Instantiate(Four).transform.position = new Vector3(89, 50);
        }
        if (loadNumber == 5)
        {
            Instantiate(Five).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 6)
        {
            Instantiate(OneV).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 7)
        {
            Instantiate(TwoV).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 8)
        {
            Instantiate(ThreeV).transform.position = new Vector3(89, 50);
        }
        if (loadNumber == 9)
        {
            Instantiate(FourV).transform.position = new Vector3(89, 50);
            AreaOnePowerUp();
        }
        if (loadNumber == 10)
        {
            Instantiate(FiveV).transform.position = new Vector3(89, 50);
        }
        loadArea1 = false;
        loadArea2 = true;
    }
    public void LoadAreaTwo()
    {
        Debug.Log(loadNumber);
        if (loadNumber == 1)
        {
            Instantiate(One).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 2)
        {
            Instantiate(Two).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 3)
        {
            Instantiate(Three).transform.position = new Vector3(189, 50);
        }
        if (loadNumber == 4)
        {
            Instantiate(Four).transform.position = new Vector3(189, 50);
        }
        if (loadNumber == 5)
        {
            Instantiate(Five).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 6)
        {
            Instantiate(OneV).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 7)
        {
            Instantiate(TwoV).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 8)
        {
            Instantiate(ThreeV).transform.position = new Vector3(189, 50);
        }
        if (loadNumber == 9)
        {
            Instantiate(FourV).transform.position = new Vector3(189, 50);
            AreaTwoPowerUp();
        }
        if (loadNumber == 10)
        {
            Instantiate(FiveV).transform.position = new Vector3(189, 50);
        }
        loadArea2 = false;
        loadArea3 = true;
    }
    public void LoadAreaThree()
    {
        Debug.Log(loadNumber);
        if (loadNumber == 1)
        {
            Instantiate(One).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 2)
        {
            Instantiate(Two).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 3)
        {
            Instantiate(Three).transform.position = new Vector3(289, 50);
        }
        if (loadNumber == 4)
        {
            Instantiate(Four).transform.position = new Vector3(289, 50);
        }
        if (loadNumber == 5)
        {
            Instantiate(Five).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 6)
        {
            Instantiate(OneV).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 7)
        {
            Instantiate(TwoV).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 8)
        {
            Instantiate(ThreeV).transform.position = new Vector3(289, 50);
        }
        if (loadNumber == 9)
        {
            Instantiate(FourV).transform.position = new Vector3(289, 50);
            AreaThreePowerUp();
        }
        if (loadNumber == 10)
        {
            Instantiate(FiveV).transform.position = new Vector3(289, 50);
        }
        loadArea3 = false;
        loadArea4 = true;
    }
    public void LoadAreaFour()
    {
        Debug.Log(loadNumber);
        if (loadNumber == 1)
        {
            Instantiate(One).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 2)
        {
            Instantiate(Two).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 3)
        {
            Instantiate(Three).transform.position = new Vector3(389, 50);
        }
        if (loadNumber == 4)
        {
            Instantiate(Four).transform.position = new Vector3(389, 50);
        }
        if (loadNumber == 5)
        {
            Instantiate(Five).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 6)
        {
            Instantiate(OneV).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 7)
        {
            Instantiate(TwoV).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 8)
        {
            Instantiate(ThreeV).transform.position = new Vector3(389, 50);
        }
        if (loadNumber == 9)
        {
            Instantiate(FourV).transform.position = new Vector3(389, 50);
            AreaFourPowerUp();
        }
        if (loadNumber == 10)
        {
            Instantiate(FiveV).transform.position = new Vector3(389, 50);
        }
        loadArea4 = false;
        loadArea5 = true;
    }
    public void LoadAreaFive()
    {
        Debug.Log(loadNumber);
        if (loadNumber == 1)
        {
            Instantiate(One).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 2)
        {
            Instantiate(Two).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 3)
        {
            Instantiate(Three).transform.position = new Vector3(489, 50);
        }
        if (loadNumber == 4)
        {
            Instantiate(Four).transform.position = new Vector3(489, 50);
        }
        if (loadNumber == 5)
        {
            Instantiate(Five).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 6)
        {
            Instantiate(OneV).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 7)
        {
            Instantiate(TwoV).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 8)
        {
            Instantiate(ThreeV).transform.position = new Vector3(489, 50);
        }
        if (loadNumber == 9)
        {
            Instantiate(FourV).transform.position = new Vector3(489, 50);
            AreaFivePowerUp();
        }
        if (loadNumber == 10)
        {
            Instantiate(FiveV).transform.position = new Vector3(489, 50);
        }
        loadArea5 = false;
    }
    public void AreaOnePowerUp()
    {
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (loadNumber == 1)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(125.5f, 23.5f);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(125.5f, 23.5f);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(125.5f, 23.5f);
        }
        if (loadNumber == 2)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(149f, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(149f, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(149f, 17);
        }
        if (loadNumber == 5)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(142.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(142.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(142.5f, 26);
        }
        if (loadNumber == 6)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(142.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(142.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(142.5f, 26);
        }
        if (loadNumber == 7)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(150, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(150, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(150, 17);
        }
        if (loadNumber == 9)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(146, 21);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(146, 21);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(146, 21);
        }
    }
    public void AreaTwoPowerUp()
    {
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (loadNumber == 1)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(225.5f, 23.5f);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(225.5f, 23.5f);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(225.5f, 23.5f);
        }
        if (loadNumber == 2)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(249f, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(249f, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(249f, 17);
        }
        if (loadNumber == 5)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(242.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(242.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(242.5f, 26);
        }
        if (loadNumber == 6)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(242.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(242.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(242.5f, 26);
        }
        if (loadNumber == 7)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(250, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(250, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(250, 17);
        }
        if (loadNumber == 9)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(246, 21);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(246, 21);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(246, 21);
        }
    }
    public void AreaThreePowerUp()
    {
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (loadNumber == 1)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(325.5f, 23.5f);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(325.5f, 23.5f);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(325.5f, 23.5f);
        }
        if (loadNumber == 2)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(349f, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(349f, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(349f, 17);
        }
        if (loadNumber == 5)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(342.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(342.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(342.5f, 26);
        }
        if (loadNumber == 6)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(342.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(342.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(342.5f, 26);
        }
        if (loadNumber == 7)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(350, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(350, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(350, 17);
        }
        if (loadNumber == 9)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(346, 21);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(346, 21);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(346, 21);
        }
    }
    public void AreaFourPowerUp()
    {
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (loadNumber == 1)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(425.5f, 23.5f);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(425.5f, 23.5f);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(425.5f, 23.5f);
        }
        if (loadNumber == 2)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(449f, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(449f, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(449f, 17);
        }
        if (loadNumber == 5)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(442.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(442.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(442.5f, 26);
        }
        if (loadNumber == 6)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(442.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(442.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(442.5f, 26);
        }
        if (loadNumber == 7)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(450, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(450, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(450, 17);
        }
        if (loadNumber == 9)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(446, 21);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(446, 21);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(446, 21);
        }
    }
    public void AreaFivePowerUp()
    {
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (loadNumber == 1)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(525.5f, 23.5f);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(525.5f, 23.5f);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(525.5f, 23.5f);
        }
        if (loadNumber == 2)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(549f, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(549f, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(549f, 17);
        }
        if (loadNumber == 5)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(542.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(542.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(542.5f, 26);
        }
        if (loadNumber == 6)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(542.5f, 26);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(542.5f, 26);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(542.5f, 26);
        }
        if (loadNumber == 7)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(550, 17);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(550, 17);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(550, 17);
        }
        if (loadNumber == 9)
        {
            if (powerNumber == 1)
                Instantiate(speedUp).transform.position = new Vector3(446, 21);
            if (powerNumber == 2)
                Instantiate(jumpUp).transform.position = new Vector3(446, 21);
            if (powerNumber == 3)
                Instantiate(delayUp).transform.position = new Vector3(446, 21);
        }
    }
}
