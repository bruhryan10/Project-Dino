using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;
    [SerializeField] GameObject Player;
    [SerializeField] PlayerMovement playerScript;
    [SerializeField] PauseUI pauseUI;
   
    PlayerInput input;
    InputAction jumps;
    InputAction move;
    InputAction pause;

    float MoveDir;

    private void Awake()
    {
        input = Player.GetComponent<PlayerInput>();
        jumps = input.actions.FindAction("jump");
        move = input.actions.FindAction("movement");
        pause = input.actions.FindAction("pause");

        jumps.performed += ctx => playerScript.JumpHandler(MoveDir);
        pause.performed += ctx => pauseUI.TogglePause();
    }

    void Update()
    {
            MoveDir = move.ReadValue<float>();
            playerScript.MovementHandler(MoveDir);
    }

    void OnEnable()
    {
        jumps.Enable();
        move.Enable();
    }

    void OnDisable()
    {
        jumps.Disable();
        move.Disable();
    }
}
