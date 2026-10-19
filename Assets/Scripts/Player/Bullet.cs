using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerDamage;
    private float speed = 20f;
    private float lifeTime = 3f;
    private float timer;
    [SerializeField] private Rigidbody2D rb;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyBehaviour enemy = collision.GetComponent<EnemyBehaviour>();
        if (enemy != null)
        {
            enemy.DoDamage(playerDamage.GetDamage());
            Destroy(gameObject);
        }
    }

    public void Shoot(float sign)
    {
        Vector3 direction = new Vector3(sign, 0f, 0f).normalized;
        transform.up = direction;
        rb.AddForce(direction * speed, ForceMode2D.Impulse);
    }

}
