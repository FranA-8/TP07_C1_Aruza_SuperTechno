using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiWinMenu : MonoBehaviour
{
    [SerializeField] private Button playAgainButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private GameObject winMenuPanel;
    bool isPaused = false;
    bool canPause = false;
    private void Awake()
    {
        playAgainButton.onClick.AddListener(OnPlayAgainButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }
    private void OnDestroy()
    {
        playAgainButton.onClick.RemoveListener(OnPlayAgainButtonClicked);
        exitButton.onClick.RemoveListener(OnExitButtonClicked);
    }
    private void OnExitButtonClicked()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 0f;
    }

    private void OnPlayAgainButtonClicked()
    {
        winMenuPanel.SetActive(false);
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
