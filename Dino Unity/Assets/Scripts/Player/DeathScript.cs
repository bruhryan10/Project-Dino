using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour
{
    PlayerMovement playerMovement;
    [SerializeField] Animator playerAnim;
    [SerializeField] Canvas deathUI;


    void Start()
    {
        deathUI.enabled = false;
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }

    public void PlayerDeath()
    {
        playerAnim.Play("DeathTwo");
        Time.timeScale = 0f;
        deathUI.enabled = true;
    }
    public void ResetAfterDeath()
    {
        Time.timeScale = 1f;
        deathUI.enabled = false;
    }
}
