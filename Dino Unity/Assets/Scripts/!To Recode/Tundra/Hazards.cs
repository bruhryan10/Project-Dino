using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    
    public float Idistance = 20f;
    public Animator animator;

    void Start()
    {
        Physics2D.queriesStartInColliders = false;
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Icicles();
    }

    public void Icicles()
    {
        if(this.gameObject.tag == "Icicle")
        {
            RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), Idistance);
            if (hitInfo.collider != null)
            {
                Debug.DrawLine(transform.position, hitInfo.point, Color.red);
                if (hitInfo.collider.CompareTag("Player"))
                {
                    GetComponent<Rigidbody2D>().gravityScale = 2;
                    Debug.Log("drop");
                }
            }
            else
                Debug.DrawLine(transform.position, transform.position + transform.TransformDirection(Vector2.up) * Idistance, Color.green);
        }

    }

    public void TarPit()
    {

        if (this.gameObject.tag == "TarPit")
        {

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.tag == "Icicle")
        {
            if (collision.collider.tag == "Ground")
            {
                IcicleBreak();
            }
        }
    }

    public void IcicleBreak()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0;
        GetComponent<PolygonCollider2D>().enabled = false;
        animator.Play("Break");
        //Destroy(gameObject);
    }



}
