using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiGameOverMenu : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private Button tryAgainButton;
    [SerializeField] private Button exitButton;
    bool isPaused = false;
    bool canPause = false;

    private void Awake()
    {
        tryAgainButton.onClick.AddListener(OnTryAgainButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void OnDestroy()
    {
        tryAgainButton.onClick.RemoveListener(OnTryAgainButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
    }

    private void OnExitButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 0f;
    }

    private void OnTryAgainButtonClicked()
    {
        gameOverPanel.SetActive(false);
        isPaused = false;
        canPause = true;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canPause == true)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
        }
    }
}
