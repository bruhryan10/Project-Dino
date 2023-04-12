using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomTerrainTundra : MonoBehaviour
{
    public GameObject player;

    public float powerNumber;
    public GameObject speedUp;
    public GameObject jumpUp;
    public GameObject delayUp;

    public GameObject AreaOneOne;
    public GameObject AreaOneTwo;
    public GameObject AreaOneThree;
    public GameObject AreaOneFour;
    public GameObject AreaOneFive;

    public GameObject AreaOneOneV;
    public GameObject AreaOneTwoV;
    public GameObject AreaOneThreeV;
    public GameObject AreaOneFourV;
    public GameObject AreaOneFiveV;

    public GameObject AreaTwoOne;
    public GameObject AreaTwoTwo;
    public GameObject AreaTwoThree;
    public GameObject AreaTwoFour;
    public GameObject AreaTwoFive;

    public GameObject AreaTwoOneV;
    public GameObject AreaTwoTwoV;
    public GameObject AreaTwoThreeV;
    public GameObject AreaTwoFourV;
    public GameObject AreaTwoFiveV;

    public GameObject AreaThreeOne;
    public GameObject AreaThreeTwo;
    public GameObject AreaThreeThree;
    public GameObject AreaThreeFour;
    public GameObject AreaThreeFive;

    public GameObject AreaThreeOneV;
    public GameObject AreaThreeTwoV;
    public GameObject AreaThreeThreeV;
    public GameObject AreaThreeFourV;
    public GameObject AreaThreeFiveV;

    public GameObject AreaFourOne;
    public GameObject AreaFourTwo;
    public GameObject AreaFourThree;
    public GameObject AreaFourFour;
    public GameObject AreaFourFive;

    public GameObject AreaFourOneV;
    public GameObject AreaFourTwoV;
    public GameObject AreaFourThreeV;
    public GameObject AreaFourFourV;
    public GameObject AreaFourFiveV;

    public GameObject AreaFiveOne;
    public GameObject AreaFiveTwo;
    public GameObject AreaFiveThree;
    public GameObject AreaFiveFour;
    public GameObject AreaFiveFive;

    public GameObject AreaFiveOneV;
    public GameObject AreaFiveTwoV;
    public GameObject AreaFiveThreeV;
    public GameObject AreaFiveFourV;
    public GameObject AreaFiveFiveV;


    public float loadNumber;
    public bool loadArea1;
    public bool loadArea2;
    public bool loadArea3;
    public bool loadArea4;
    public bool loadArea5;
    private void Awake()
    {
        AreaOneOne.SetActive(false);
        AreaOneTwo.SetActive(false);
        AreaOneThree.SetActive(false);
        AreaOneFour.SetActive(false);
        AreaOneFive.SetActive(false);

        AreaOneOneV.SetActive(false);
        AreaOneTwoV.SetActive(false);
        AreaOneThreeV.SetActive(false);
        AreaOneFourV.SetActive(false);
        AreaOneFiveV.SetActive(false);

        AreaTwoOne.SetActive(false);
        AreaTwoTwo.SetActive(false);
        AreaTwoThree.SetActive(false);
        AreaTwoFour.SetActive(false);
        AreaTwoFive.SetActive(false);

        AreaTwoOneV.SetActive(false);
        AreaTwoTwoV.SetActive(false);
        AreaTwoThreeV.SetActive(false);
        AreaTwoFourV.SetActive(false);
        AreaTwoFiveV.SetActive(false);

        AreaThreeOne.SetActive(false);
        AreaThreeTwo.SetActive(false);
        AreaThreeThree.SetActive(false);
        AreaThreeFour.SetActive(false);
        AreaThreeFive.SetActive(false);

        AreaThreeOneV.SetActive(false);
        AreaThreeTwoV.SetActive(false);
        AreaThreeThreeV.SetActive(false);
        AreaThreeFourV.SetActive(false);
        AreaThreeFiveV.SetActive(false);

        AreaFourOne.SetActive(false);
        AreaFourTwo.SetActive(false);
        AreaFourThree.SetActive(false);
        AreaFourFour.SetActive(false);
        AreaFourFive.SetActive(false);

        AreaFourOneV.SetActive(false);
        AreaFourTwoV.SetActive(false);
        AreaFourThreeV.SetActive(false);
        AreaFourFourV.SetActive(false);
        AreaFourFiveV.SetActive(false);

        AreaFiveOne.SetActive(false);
        AreaFiveTwo.SetActive(false);
        AreaFiveThree.SetActive(false);
        AreaFiveFour.SetActive(false);
        AreaFiveFive.SetActive(false);

        AreaFiveOneV.SetActive(false);
        AreaFiveTwoV.SetActive(false);
        AreaFiveThreeV.SetActive(false);
        AreaFiveFourV.SetActive(false);
        AreaFiveFiveV.SetActive(false);


        loadArea1 = true;
    }

    void Update()
    {
        if (player.transform.position.x > 76 && loadArea1 == true)
        {
            loadNumber = Random.Range(1, 11);
            Debug.Log(loadNumber);
            if (loadNumber == 1)
                LoadAreaOneOne();
            if (loadNumber == 2)
                LoadAreaOneTwo();
            if (loadNumber == 3)
                LoadAreaOneThree();
            if (loadNumber == 4)
                LoadAreaOneFour();
            if (loadNumber == 5)
                LoadAreaOneFive();
            if (loadNumber == 6)
                LoadAreaOneOneV();
            if (loadNumber == 7)
                LoadAreaOneTwoV();
            if (loadNumber == 8)
                LoadAreaOneThreeV();
            if (loadNumber == 9)
                LoadAreaOneFourV();
            if (loadNumber == 10)
                LoadAreaOneFiveV();
            loadArea1 = false;
            loadArea2 = true;
        }
        if (player.transform.position.x > 176 && loadArea2 == true)
        {
            loadNumber = Random.Range(1, 11);
            Debug.Log(loadNumber);
            if (loadNumber == 1)
                LoadAreaTwoOne();
            if (loadNumber == 2)
                LoadAreaTwoTwo();
            if (loadNumber == 3)
                LoadAreaTwoThree();
            if (loadNumber == 4)
                LoadAreaTwoFour();
            if (loadNumber == 5)
                LoadAreaTwoFive();
            if (loadNumber == 6)
                LoadAreaTwoOneV();
            if (loadNumber == 7)
                LoadAreaTwoTwoV();
            if (loadNumber == 8)
                LoadAreaTwoThreeV();
            if (loadNumber == 9)
                LoadAreaTwoFourV();
            if (loadNumber == 10)
                LoadAreaTwoFiveV();
            loadArea2 = false;
            loadArea3 = true;
        }
        if (player.transform.position.x > 276 && loadArea3 == true)
        {
            loadNumber = Random.Range(1, 11);
            Debug.Log(loadNumber);
            if (loadNumber == 1)
                LoadAreaThreeOne();
            if (loadNumber == 2)
                LoadAreaThreeTwo();
            if (loadNumber == 3)
                LoadAreaThreeThree();
            if (loadNumber == 4)
                LoadAreaThreeFour();
            if (loadNumber == 5)
                LoadAreaThreeFive();
            if (loadNumber == 6)
                LoadAreaThreeOneV();
            if (loadNumber == 7)
                LoadAreaThreeTwoV();
            if (loadNumber == 8)
                LoadAreaThreeThreeV();
            if (loadNumber == 9)
                LoadAreaThreeFourV();
            if (loadNumber == 10)
                LoadAreaThreeFiveV();
            loadArea3 = false;
            loadArea4 = true;
        }
        if (player.transform.position.x > 376 && loadArea4 == true)
        {
            loadNumber = Random.Range(1, 11);
            Debug.Log(loadNumber);
            if (loadNumber == 1)
                LoadAreaFourOne();
            if (loadNumber == 2)
                LoadAreaFourTwo();
            if (loadNumber == 3)
                LoadAreaFourThree();
            if (loadNumber == 4)
                LoadAreaFourFour();
            if (loadNumber == 5)
                LoadAreaFourFive();
            if (loadNumber == 6)
                LoadAreaFourOneV();
            if (loadNumber == 7)
                LoadAreaFourTwoV();
            if (loadNumber == 8)
                LoadAreaFourThreeV();
            if (loadNumber == 9)
                LoadAreaFourFourV();
            if (loadNumber == 10)
                LoadAreaFourFiveV();
            loadArea4 = false;
            loadArea5 = true;
        }
        if (player.transform.position.x > 476 && loadArea5 == true)
        {
            loadNumber = Random.Range(1, 11);
            Debug.Log(loadNumber);
            if (loadNumber == 1)
                LoadAreaFiveOne();
            if (loadNumber == 2)
                LoadAreaFiveTwo();
            if (loadNumber == 3)
                LoadAreaFiveThree();
            if (loadNumber == 4)
                LoadAreaFiveFour();
            if (loadNumber == 5)
                LoadAreaFiveFive();
            if (loadNumber == 6)
                LoadAreaFiveOneV();
            if (loadNumber == 7)
                LoadAreaFiveTwoV();
            if (loadNumber == 8)
                LoadAreaFiveThreeV();
            if (loadNumber == 9)
                LoadAreaFiveFourV();
            if (loadNumber == 10)
                LoadAreaFiveFiveV();
            loadArea5 = false;
        }
    }
    public void LoadAreaOneOne()
    {
        AreaOneOne.SetActive(true);
        AreaOneOne.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 25.5f);
    }
    public void LoadAreaOneTwo()
    {
        AreaOneTwo.SetActive(true);
        AreaOneTwo.transform.position = new Vector3(89, 50);
    }
    public void LoadAreaOneThree()
    {
        AreaOneThree.SetActive(true);
        AreaOneThree.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(159.6f, 17.5f);
    }
    public void LoadAreaOneFour()
    {
        AreaOneFour.SetActive(true);
        AreaOneFour.transform.position = new Vector3(89, 50);
    }
    public void LoadAreaOneFive()
    {
        AreaOneFive.SetActive(true);
        AreaOneFive.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(137f, 18.5f);
    }
    public void LoadAreaOneOneV()
    {
        AreaOneOneV.SetActive(true);
        AreaOneOneV.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(161.5f, 17.5f);
    }
    public void LoadAreaOneTwoV()
    {
        AreaOneTwoV.SetActive(true);
        AreaOneTwoV.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 11.5f);
    }
    public void LoadAreaOneThreeV()
    {
        AreaOneThreeV.SetActive(true);
        AreaOneThreeV.transform.position = new Vector3(89, 50);
    }
    public void LoadAreaOneFourV()
    {
        AreaOneFourV.SetActive(true);
        AreaOneFourV.transform.position = new Vector3(89, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(140.5f, 19.5f);
    }
    public void LoadAreaOneFiveV()
    {
        AreaOneFiveV.SetActive(true);
        AreaOneFiveV.transform.position = new Vector3(89, 50);
    }
    //--------------------------------------------------------------------------
    public void LoadAreaTwoOne()
    {
        AreaTwoOne.SetActive(true);
        AreaTwoOne.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 25.5f);
    }
    public void LoadAreaTwoTwo()
    {
        AreaTwoTwo.SetActive(true);
        AreaTwoTwo.transform.position = new Vector3(189, 50);
    }
    public void LoadAreaTwoThree()
    {
        AreaTwoThree.SetActive(true);
        AreaTwoThree.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(159.6f, 17.5f);
    }
    public void LoadAreaTwoFour()
    {
        AreaTwoFour.SetActive(true);
        AreaTwoFour.transform.position = new Vector3(189, 50);
    }
    public void LoadAreaTwoFive()
    {
        AreaTwoFive.SetActive(true);
        AreaTwoFive.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(137f, 18.5f);
    }
    public void LoadAreaTwoOneV()
    {
        AreaTwoOneV.SetActive(true);
        AreaTwoOneV.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(161.5f, 17.5f);
    }
    public void LoadAreaTwoTwoV()
    {
        AreaTwoTwoV.SetActive(true);
        AreaTwoTwoV.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 11.5f);
    }
    public void LoadAreaTwoThreeV()
    {
        AreaTwoThreeV.SetActive(true);
        AreaTwoThreeV.transform.position = new Vector3(189, 50);
    }
    public void LoadAreaTwoFourV()
    {
        AreaTwoFourV.SetActive(true);
        AreaTwoFourV.transform.position = new Vector3(189, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(140.5f, 19.5f);
    }
    public void LoadAreaTwoFiveV()
    {
        AreaTwoFiveV.SetActive(true);
        AreaTwoFiveV.transform.position = new Vector3(189, 50);
    }
    //-----------------------------------------------------------
    public void LoadAreaThreeOne()
    {
        AreaThreeOne.SetActive(true);
        AreaThreeOne.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 25.5f);
    }
    public void LoadAreaThreeTwo()
    {
        AreaThreeTwo.SetActive(true);
        AreaThreeTwo.transform.position = new Vector3(289, 50);
    }
    public void LoadAreaThreeThree()
    {
        AreaThreeThree.SetActive(true);
        AreaThreeThree.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(159.6f, 17.5f);
    }
    public void LoadAreaThreeFour()
    {
        AreaThreeFour.SetActive(true);
        AreaThreeFour.transform.position = new Vector3(289, 50);
    }
    public void LoadAreaThreeFive()
    {
        AreaThreeFive.SetActive(true);
        AreaThreeFive.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(137f, 18.5f);
    }
    public void LoadAreaThreeOneV()
    {
        AreaThreeOneV.SetActive(true);
        AreaThreeOneV.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(161.5f, 17.5f);
    }
    public void LoadAreaThreeTwoV()
    {
        AreaThreeTwoV.SetActive(true);
        AreaThreeTwoV.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 11.5f);
    }
    public void LoadAreaThreeThreeV()
    {
        AreaThreeThreeV.SetActive(true);
        AreaThreeThreeV.transform.position = new Vector3(289, 50);
    }
    public void LoadAreaThreeFourV()
    {
        AreaThreeFourV.SetActive(true);
        AreaThreeFourV.transform.position = new Vector3(289, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(140.5f, 19.5f);
    }
    public void LoadAreaThreeFiveV()
    {
        AreaThreeFiveV.SetActive(true);
        AreaThreeFiveV.transform.position = new Vector3(289, 50);
    }
    //--------------------------------------------------------------------
    public void LoadAreaFourOne()
    {
        AreaFourOne.SetActive(true);
        AreaFourOne.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 25.5f);
    }
    public void LoadAreaFourTwo()
    {
        AreaFourTwo.SetActive(true);
        AreaFourTwo.transform.position = new Vector3(389, 50);
    }
    public void LoadAreaFourThree()
    {
        AreaFourThree.SetActive(true);
        AreaFourThree.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(159.6f, 17.5f);
    }
    public void LoadAreaFourFour()
    {
        AreaFourFour.SetActive(true);
        AreaFourFour.transform.position = new Vector3(389, 50);
    }
    public void LoadAreaFourFive()
    {
        AreaFourFive.SetActive(true);
        AreaFourFive.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(137f, 18.5f);
    }
    public void LoadAreaFourOneV()
    {
        AreaFourOneV.SetActive(true);
        AreaFourOneV.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(161.5f, 17.5f);
    }
    public void LoadAreaFourTwoV()
    {
        AreaFourTwoV.SetActive(true);
        AreaFourTwoV.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 11.5f);
    }
    public void LoadAreaFourThreeV()
    {
        AreaFourThreeV.SetActive(true);
        AreaFourThreeV.transform.position = new Vector3(389, 50);
    }
    public void LoadAreaFourFourV()
    {
        AreaFourFourV.SetActive(true);
        AreaFourFourV.transform.position = new Vector3(389, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(140.5f, 19.5f);
    }
    public void LoadAreaFourFiveV()
    {
        AreaFourFiveV.SetActive(true);
        AreaFourFiveV.transform.position = new Vector3(389, 50);
    }
    //-------------------------------------------------------------
    public void LoadAreaFiveOne()
    {
        AreaFiveOne.SetActive(true);
        AreaFiveOne.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 25.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 25.5f);
    }
    public void LoadAreaFiveTwo()
    {
        AreaFiveTwo.SetActive(true);
        AreaFiveTwo.transform.position = new Vector3(489, 50);
    }
    public void LoadAreaFiveThree()
    {
        AreaFiveThree.SetActive(true);
        AreaFiveThree.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(159.6f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(159.6f, 17.5f);
    }
    public void LoadAreaFiveFour()
    {
        AreaFiveFour.SetActive(true);
        AreaFiveFour.transform.position = new Vector3(489, 50);
    }
    public void LoadAreaFiveFive()
    {
        AreaFiveFive.SetActive(true);
        AreaFiveFive.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(137f, 18.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(137f, 18.5f);
    }
    public void LoadAreaFiveOneV()
    {
        AreaFiveOneV.SetActive(true);
        AreaFiveOneV.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(161.5f, 17.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(161.5f, 17.5f);
    }
    public void LoadAreaFiveTwoV()
    {
        AreaFiveTwoV.SetActive(true);
        AreaFiveTwoV.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(129.5f, 11.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(129.5f, 11.5f);
    }
    public void LoadAreaFiveThreeV()
    {
        AreaFiveThreeV.SetActive(true);
        AreaFiveThreeV.transform.position = new Vector3(489, 50);
    }
    public void LoadAreaFiveFourV()
    {
        AreaFiveFourV.SetActive(true);
        AreaFiveFourV.transform.position = new Vector3(489, 50);
        powerNumber = Random.Range(1, 4);
        Debug.Log(powerNumber);
        if (powerNumber == 1)
            Instantiate(speedUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 2)
            Instantiate(jumpUp).transform.position = new Vector3(140.5f, 19.5f);
        if (powerNumber == 3)
            Instantiate(delayUp).transform.position = new Vector3(140.5f, 19.5f);
    }
    public void LoadAreaFiveFiveV()
    {
        AreaFiveFiveV.SetActive(true);
        AreaFiveFiveV.transform.position = new Vector3(489, 50);
    }
}
