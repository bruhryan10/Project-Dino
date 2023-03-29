using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSceneTest : MonoBehaviour
{
    public Vector3 loadPoint;
    public GameObject player;
    void Start()
    {
        loadPoint = new Vector3(10.5f, 1.5f);
        
    }

    void Update()
    {
        if (player.transform.position == loadPoint)
        {
            Debug.Log("working");
        }
    }
}
