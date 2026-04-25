using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public TMP_Text scoreText;
    public GameObject gameOverPanel;
    public TMP_Text totalScore;

    private int score = 0;
    private bool gameOver = false;

    void Awake()
    {
        Instance = this;
        Time.timeScale = 1f;
    }

    void Start()
    {
        UpdateScoreText();

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);
    }

    public void AddScore()
    {
        if (gameOver) return;

        score++;
        print(score);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        gameOver = true;
        Time.timeScale = 0f;

        if (gameOverPanel != null)
        {
            gameOverPanel.SetActive(true);
            totalScore.text = "Ваш счет:" + score.ToString();

        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
