
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    public Playermovement playerMovement;
    public PlayerJump playerJump;
    public PlayerReset playerReset;
    public void Movement(InputAction.CallbackContext context)
    {
        playerMovement.OnMovement(new Vector2(context.ReadValue<Vector2>().x, context.ReadValue<Vector2>().y));
    }
    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerJump.Jump();
        }
    }
    public void ResetPlayer(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            playerReset.ResetPlayer();
        }
    }
}
