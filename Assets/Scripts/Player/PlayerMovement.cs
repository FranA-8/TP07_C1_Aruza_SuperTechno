using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float playerPositionX = -2.35f;
    private float playerPositionY = -5.88f;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private GameObject player;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float maxSpeed;
    private Rigidbody2D rb;
    private void Start()
    {
        moveSpeed = data.moveSpeed;
    }
    public void PowerUpMoveSpeed(float value)
    {
        moveSpeed += value;
    }

    public float GetMoveSpeed()
    {
        return moveSpeed;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(new Vector2(moveSpeed * Time.fixedDeltaTime, 0f), ForceMode2D.Force);

        float velocityX = Mathf.Clamp(rb.linearVelocity.x, 0f, maxSpeed);

        rb.linearVelocity = new Vector2 (velocityX, rb.linearVelocity.y);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LoopWall"))
        {
            player.transform.position = new Vector2(playerPositionX, playerPositionY);

        }
    }
}
