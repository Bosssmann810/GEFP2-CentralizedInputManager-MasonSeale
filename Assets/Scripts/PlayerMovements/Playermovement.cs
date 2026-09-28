using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;


    public void OnMovement(Vector2 movement)
    {
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.y);
    }
}
