using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hazards : MonoBehaviour
{
    
    public float Idistance = 20f;
    
    
    
    
    
    
    

    // Start is called before the first frame update
    void Start()
    {
        Physics2D.queriesStartInColliders = false;
        
        
    }

    // Update is called once per frame
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
                    GetComponent<Rigidbody2D>().gravityScale = 1;
                    Debug.Log("drop");
                }
            }
            else
            {
                Debug.DrawLine(transform.position, transform.position + transform.TransformDirection(Vector2.up) * Idistance, Color.green);

            }
            
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

        //play shatter animation
        Destroy(gameObject);


    }
}
