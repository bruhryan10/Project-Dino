using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    public Vector3 moveDir;
    public float moveSpeed = 8f;
    public float jumpHeight = 5f;
    Vector3 Velocity;
    Vector3 Jump;

    void Start()
    {
        
    }

    void Update()
    {
        Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - 10);

        Jump = Vector3.zero;
        Velocity = Vector3.zero;
        if (Input.GetKey(KeyCode.D))
        {
            Velocity += Vector3.right;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Velocity += Vector3.left;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Jump += Vector3.up;
        }

        Jump *= jumpHeight;

        transform.position += Jump * Time.deltaTime;

        Velocity *= moveSpeed;

        transform.position += Velocity * Time.deltaTime;

    }
}
