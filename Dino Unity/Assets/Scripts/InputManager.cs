using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    [SerializeField] GameObject Player;
    [SerializeField] PlayerMovement playerScript;
    InputAction jumps;
    InputAction move;
    PlayerInput input;
    float MoveDir;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        GameObject playerObject = GameObject.FindWithTag("Player");
        if (playerObject != null)
        {
            input = playerObject.GetComponent<PlayerInput>();
            if (input != null)
            {
                jumps = input.actions.FindAction("jump");
                move = input.actions.FindAction("movement");
                if (jumps != null)
                {
                    jumps.performed += ctx => playerScript.JumpHandler(MoveDir);
                }
                else
                {
                    Debug.LogError("Jump action not found!");
                }
            }
            else
            {
                Debug.LogError("PlayerInput component not found on Player GameObject!");
            }
        }
        else
        {
            Debug.LogError("Player GameObject not found in scene!");
        }
    }

    void Update()
    {
        Player = GameObject.FindWithTag("Player");
        playerScript = Player.GetComponent<PlayerMovement>();
        if (input != null && playerScript != null)
        {
            MoveDir = move.ReadValue<float>();
            playerScript.MovementHandler(MoveDir);
        }
    }

    void OnEnable()
    {
        if (jumps != null && move != null)
        {
            jumps.Enable();
            move.Enable();
        }
        else
        {
            Debug.LogError("Input actions not initialized!");
        }
    }

    void OnDisable()
    {
        if (jumps != null && move != null)
        {
            jumps.Disable();
            move.Disable();
        }
    }
}
