using System.Threading;
using UnityEngine;

public class AudioBackground : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    private float gameStart = 0;
    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= gameStart)
        {
            if (audioSource != null)
            {

                audioSource.Play();
                
            }
        }
    }
}
