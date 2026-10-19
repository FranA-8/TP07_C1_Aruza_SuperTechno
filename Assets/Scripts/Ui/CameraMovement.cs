using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, 0, 0);
    }
}
