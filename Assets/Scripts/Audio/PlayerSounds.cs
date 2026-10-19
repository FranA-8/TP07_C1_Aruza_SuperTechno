using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private AudioSource audioSource;

    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip shootSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpSound);
    }

    public void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
}