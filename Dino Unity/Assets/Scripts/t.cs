using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class t : MonoBehaviour
{
    [SerializeField] InputAction jump;
    [SerializeField] PlayerInput input;
    void Start()
    {
        input = GetComponent<PlayerInput>();
        jump = input.actions.FindAction("HE");
        jump.performed += ctx => Debug.Log("Pressed!");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
