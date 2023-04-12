using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropDinoWalk : MonoBehaviour
{
    public float leftTimeMin = 2f;
    public float leftTimeMax = 6f;
    public float rightTimeMin = 2f; 
    public float rightTimeMax = 6f; 
    public float moveSpeed = 5f;
    public float moveNumber;
    public bool moveLeft;
    public bool moveRight;

    void Start()
    {
        Left();
    }

    void Update()
    {
        if (moveLeft)
        {
            moveNumber -= Time.deltaTime;
            transform.position = new Vector3(transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);
            if (moveNumber <= 0)
                Right();

        }
        if (moveRight)
        {
            moveNumber -= Time.deltaTime;
            transform.position = new Vector3(-transform.position.x + (moveSpeed * Time.deltaTime), transform.position.y);
            if (moveNumber <= 0)
                Left();

        }
    }
    public void Left()
    {
        moveLeft = true;
        moveRight = false;
        moveNumber = Random.Range(leftTimeMin, leftTimeMax);
        Debug.Log(moveNumber);

    }
    public void Right()
    {
        moveRight = true;
        moveLeft = false;
        moveNumber = Random.Range(leftTimeMin, leftTimeMax);
        Debug.Log(moveNumber);

    }
}
