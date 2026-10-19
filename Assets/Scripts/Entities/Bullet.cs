using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private PlayerDataSo data;
    private float damage;
    private float speed = 20f;
    private float lifeTime = 3f;
    private float timer;
    [SerializeField] private Rigidbody2D rb;
    private void Start()
    {
        damage = data.damage;
    }
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= lifeTime)
        {
            Destroy(gameObject);
        }
    }
    public void PowerUpDamage(float value)
    {
        damage += value;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        EnemyBehaviour enemy = collision.GetComponent<EnemyBehaviour>();
        if (enemy != null)
        {
            enemy.DoDamage(damage);
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
