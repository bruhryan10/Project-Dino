using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropDinoWalk : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float moveTimer = 3f;
    public bool moveLeft;

    void Start()
    {
        moveLeft = true;
    }

    void Update()
    {
        if (moveLeft)
        {
            transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);
            moveTimer -= Time.deltaTime;
            if (moveTimer <= 0)
            {
                moveLeft = false;
                moveTimer = 3f;
            }
        }
        //if (!moveLeft)
        //{
        //    transform.position = new Vector3(-ransform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);
        //    moveTimer -= Time.deltaTime;
        //    if (moveTimer <= 0)
        //    {
        //        moveLeft = true;
        //        moveTimer = 3f;
        //    }
        //}
    }
}
