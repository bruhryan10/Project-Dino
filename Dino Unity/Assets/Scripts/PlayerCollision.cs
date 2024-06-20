using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    StartManager start;
    void Start()
    {
        start = GameObject.Find("StartManager").GetComponent<StartManager>();
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "StartTrigger")
        {
            start.StartGame();
        }
    }
}
