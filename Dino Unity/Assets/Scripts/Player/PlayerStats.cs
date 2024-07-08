using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] int jumpSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SetSpeed(int num)
    {
        moveSpeed += num;
    }
    public void SetJump(int num)
    {
        jumpSpeed += num;
    }
    public int GetSpeed()
    {
        return moveSpeed;
    }
    public int GetJump()
    {
        return jumpSpeed;
    }
}
