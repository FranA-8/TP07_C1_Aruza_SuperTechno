using UnityEngine;

public class WinCollider : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject winMenuPanel;
    private float playerPositionX = -2.35f;
    private float playerPositionY = -5.88f;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            winMenuPanel.SetActive(true);
            Time.timeScale = 0f;
            player.transform.position = new Vector2(playerPositionX, playerPositionY);
        }
    }
}
