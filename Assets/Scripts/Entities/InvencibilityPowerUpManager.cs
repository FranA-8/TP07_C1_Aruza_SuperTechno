using TMPro;
using UnityEngine;

public class InvencibilityPowerUpManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject powerUpPrefab;
    [SerializeField] private PlayerInmortality player;
    [SerializeField] private GameObject invencibilityCountDownPanel;
    [SerializeField] private TMP_Text invencibilityNumberText;
    [SerializeField] private float invencibilityTimer = 5;
    private bool collected = false;
    private float timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            player.IsPlayerInmortal(true);

            collected = true;

            animator.SetTrigger("Collected");

            timer = invencibilityTimer;
        }
    }
    private void Update()
    {
        if (collected == true)
        {
            timer -= Time.deltaTime;

            invencibilityCountDownPanel.SetActive(true);

            invencibilityNumberText.text = timer.ToString("f0");

            player.InmortalityTrail(true);

            if (timer <= 0)
            {
                player.IsPlayerInmortal(false);

                invencibilityCountDownPanel.SetActive(false);

                player.InmortalityTrail(false);

                collected = false;

                timer = invencibilityTimer;
            }
        }
    }
}
