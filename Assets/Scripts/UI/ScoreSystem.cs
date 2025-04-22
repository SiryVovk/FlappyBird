using TMPro;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int score = 0;

    private const string MAX_SCORE_KEY = "MaxScore";
    private void OnEnable()
    {
        PlayerCollision.OnPlayerPilarFlyThroough += AddScore;
        PlayerCollision.OnPlayerDeath += SetMaxScore;
    }

    private void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    private void SetMaxScore()
    {
        if (score > PlayerPrefs.GetInt(MAX_SCORE_KEY))
        {
            PlayerPrefs.SetInt(MAX_SCORE_KEY, score);
        }
    }

    public int GetMaxScore()
    {
        return PlayerPrefs.GetInt(MAX_SCORE_KEY);
    }

    public int GetScore()
    {
        return score;
    }
}
