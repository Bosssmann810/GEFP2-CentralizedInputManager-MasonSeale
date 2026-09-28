using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public Rigidbody body;
    public void Jump()
    {
        body.AddForce(Vector3.up * 100);
    }
}
