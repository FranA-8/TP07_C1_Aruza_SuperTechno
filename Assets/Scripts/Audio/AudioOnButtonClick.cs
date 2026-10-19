using UnityEngine;
using UnityEngine.UI;

public class AudioOnButtonClick : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField]private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        button.onClick.AddListener(OnButtonClicked);
    }

    private void OnDestroy()
    {
       button.onClick.RemoveListener(OnButtonClicked);
    }
    public void OnButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

    }

}
