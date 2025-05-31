using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInput playerInput;
    [SerializeField]
    private PlayerController playerController;
    // Start is called before the first frame update
    void Awake()
    {
        playerInput = GetComponent<PlayerInput>();
        var controllers = FindObjectsOfType<PlayerController>();
        var index = playerInput.playerIndex;
        playerController = controllers.FirstOrDefault(p => p.playerIndex == index);
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerController.moveAxis = context.ReadValue<Vector2>();
    }

    public void Shoot(InputAction.CallbackContext context)
    {
        playerController.isShooting = true;
    }
}
