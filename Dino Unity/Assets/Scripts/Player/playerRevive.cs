using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerRevive : MonoBehaviour
{

    public Canvas deathUI;
    public GameObject ad;
    public GameObject cur;
    public GameObject noAd;
    public GameObject noCur;
    PlayerMovement movement;
    DeathScript death;
    EnemyScript enemy;
    playerCur pCur;
    public bool ded;
    public int dedNum;

    void Start()
    {
        movement = GameObject.Find("Player").GetComponent<PlayerMovement>();
        death = GameObject.Find("Player").GetComponent<DeathScript>();
        enemy = GameObject.Find("Enemy").GetComponent<EnemyScript>();
        pCur = GameObject.Find("Player").GetComponent<playerCur>();
        ad.SetActive(false);
        cur.SetActive(false);
        noAd.SetActive(false);
        noCur.SetActive(false);
        dedNum = 0;
    }

    void Update()
    {
        if (movement.isDead && dedNum == 0)
            ded = true;
        if (movement.isDead && dedNum == 1)
        {
            ded = false;
            ad.SetActive(false);
            cur.SetActive(false);
            noAd.SetActive(false);
            noCur.SetActive(false);
        }
        if (ded)
        {
            if (pCur.curNum < 10)
            {
                noCur.SetActive(true);
                ad.SetActive(true);
            }
            if (pCur.curNum >= 10)
            {
                cur.SetActive(true);
                ad.SetActive(true);
            }
        }
    }
    public void RevAd()
    {
        //watch ad code here
        enemy.restart();
        death.IsNotDead();
        movement.DelayEnemy();
        movement.isDead = false;
        dedNum = 1;
    }
    public void RevCur()
    {
        pCur.curNum -= 10;
        enemy.restart();
        death.IsNotDead();
        movement.DelayEnemy();
        movement.isDead = false;
        dedNum = 1;
    }
}
