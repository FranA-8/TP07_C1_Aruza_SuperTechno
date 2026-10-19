using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private PlayerDataSo data;
    [SerializeField] private GameObject player;
    private float moveSpeed = 600;
    private float playerDamage = 20f;
    private Rigidbody2D rb;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
           Bullet bullet= Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
           bullet.Shoot(Mathf.Sign(transform.right.x));
        }

        if (Input.GetKey(KeyCode.D))
        {
           
            rb.AddForce(Vector2.right * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.A))
        {
            
            rb.AddForce(Vector2.left * (moveSpeed * Time.deltaTime), ForceMode2D.Force);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
           transform.right = Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.right = Vector3.left;
        }
    }
    public void PowerUpDamage(float value)
    {
        playerDamage += value;
        if (playerDamage > 50)
        {
            playerDamage = 50;
        }
    }
    public float GetDamage()
    {
        return playerDamage;
    }
    private void Start()
    {
        moveSpeed = data.moveSpeed;
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
