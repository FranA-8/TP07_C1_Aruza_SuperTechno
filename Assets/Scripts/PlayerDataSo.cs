using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Data/Game/Player")]

public class PlayerDataSo : ScriptableObject
{
    [Header("Jump")]
    public float jumpForce = 15f;

    [Header("Speed")]
    public float moveSpeed = 700f;

    [Header("Lives")]
    [Range(0, 3)] public int playerLives = 1;
    
}
