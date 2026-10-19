using UnityEngine;

public class DamagePowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerDataSo data;
    private float powerUpDamage = 10f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            data.damage += powerUpDamage;
            if (data.damage > 50)
            {
                data.damage = 50;
            }

            animator.SetTrigger("Collected");

        }
    }
}
