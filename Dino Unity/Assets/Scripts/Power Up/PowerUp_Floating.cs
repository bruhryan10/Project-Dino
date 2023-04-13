using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PowerUp_Floating : MonoBehaviour
{

    public float distance = 1.5f;
    public LayerMask ground;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        GetComponent<Rigidbody2D>().drag = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.TransformDirection(-Vector2.up), distance, ground);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);
            GetComponent<Rigidbody2D>().gravityScale = -0.5f;
            //Debug.Log("bounce");
            StartCoroutine(Floating());
            
        }
        if(hitInfo.collider == null)
        {
            Debug.DrawLine(transform.position, transform.position + transform.TransformDirection(-Vector2.up) * distance, Color.green);
            GetComponent<Rigidbody2D>().gravityScale = 0.5f;
        }
            
    }

    IEnumerator Floating()
    {
        
        yield return new WaitForSecondsRealtime(6);
        GetComponent<Rigidbody2D>().drag = 0;
        

    }
}
