using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControll : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private TMP_Text maxScore;
    [SerializeField] private TMP_Text onPanelScore;
    [SerializeField] private TMP_Text onPanelMaxScore;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject jumpText;

    [SerializeField] private ScoreSystem scoreSystem;

    private bool isGameStarted = false;

    private void OnEnable()
    {
        PlayerInput.JumpEvent += StartGame;
        PlayerCollision.OnPlayerDeath += GameEnd;
    }

    private void OnDisable()
    {
        PlayerInput.JumpEvent -= StartGame;
        PlayerCollision.OnPlayerDeath -= GameEnd;
    }

    private void StartGame()
    {
        if (isGameStarted)
        {
            return;
        }

        Time.timeScale = 1f;
        jumpText.SetActive(false);
        score.gameObject.SetActive(true);
        maxScore.gameObject.SetActive(true);
        maxScore.text = "Max Score: " + scoreSystem.GetMaxScore();
        isGameStarted = true;
    }

    private void GameEnd()
    {
        Time.timeScale = 0;
        score.gameObject.SetActive(false);
        maxScore.gameObject.SetActive(false);
        panel.SetActive(true);
        onPanelScore.text = "Score: " + scoreSystem.GetScore();
        onPanelMaxScore.text = "Max Score: " + scoreSystem.GetMaxScore();
    }

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
