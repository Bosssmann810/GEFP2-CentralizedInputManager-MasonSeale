using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Transform resetPoint;

    public GameObject player;  

    public void ResetPlayer()
    {
        player.transform.position = resetPoint.position;
    }
}
