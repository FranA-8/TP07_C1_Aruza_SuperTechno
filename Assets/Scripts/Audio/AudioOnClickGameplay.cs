using UnityEngine;
using UnityEngine.UI;

public class AudioOnClickGameplay : MonoBehaviour
{
    [SerializeField] private Button continueButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button settingsButton;
    [SerializeField] private Button creditsButton;
    [SerializeField] private Button backSettingsButton;
    [SerializeField] private Button backCreditsButton;
    [SerializeField] private AudioSource audioSource;

    private void Awake()
    {
        continueButton.onClick.AddListener(OnContinueButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
        settingsButton.onClick.AddListener(OnSettingsButtonClicked);
        creditsButton.onClick.AddListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.AddListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.AddListener(OnBackCreditsButtonClicked);
    }


    private void OnDestroy()
    {
        continueButton.onClick.RemoveListener(OnContinueButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
        settingsButton.onClick.RemoveListener(OnSettingsButtonClicked);
        creditsButton.onClick.RemoveListener(OnCreditsButtonClicked);
        backSettingsButton.onClick.RemoveListener(OnBackSettingsButtonClicked);
        backCreditsButton.onClick.RemoveListener(OnBackCreditsButtonClicked);
    }
    private void OnBackCreditsButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnBackSettingsButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnCreditsButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnSettingsButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnExitButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }

    private void OnContinueButtonClicked()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
    }
}
