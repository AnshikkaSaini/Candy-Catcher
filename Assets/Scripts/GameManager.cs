using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject livesHolder;
    public GameObject gameOverPanel;


    int score = 0;
    bool gameOver = false;
    public Text ScoreText;
    int lives = 3;
    private void Awake()
    {
        instance = this;
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            ScoreText.text = score.ToString();
            // print(score);
        }
    }

    public void DecrementLives()
    {
        lives--;
        print(lives);

        livesHolder.transform.GetChild(lives).gameObject.SetActive(false);

        if (lives <= 0)
        {
            gameOver = true;
            GameOver();
        }
    }

    public void GameOver()
    {
        CandySpawner.instance.StopSpawningCandies();

        GameObject.Find("Player").GetComponent<PlayerController>().canMove = false;

        gameOverPanel.SetActive(true);
        print("Game Over");
    }
}
