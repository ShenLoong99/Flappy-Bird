using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public AudioSource dingSFX;
    public AudioSource gameOverSFX;

    public Text highScoreText;       // NEW: UI Text to display high score

    //[ContextMenu("Increase Score")]
    private int highScore;           // stores the current session’s high score

    void Start()
    {
        // Load high score from PlayerPrefs (persistent)
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateHighScoreUI();
    }

    public void addScore(int scoreToAdd)
    {
        if (!gameOverScreen.activeSelf)
        {
            playerScore += scoreToAdd;
            scoreText.text = playerScore.ToString();

            // Check if new high score is achieved
            if (playerScore > highScore)
            {
                highScore = playerScore;
                PlayerPrefs.SetInt("HighScore", highScore); // save to device
                PlayerPrefs.Save();
                UpdateHighScoreUI();
            }

            if (dingSFX != null) dingSFX.Play();
        }
    }

    void UpdateHighScoreUI()
    {
        if (highScoreText != null)
            highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        if (!gameOverScreen.activeSelf)
        {
            gameOverScreen.SetActive(true);
            gameOverSFX.Play();
        }
    }
}
