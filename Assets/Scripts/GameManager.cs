using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;
    bool gameOver = false;
    public Text ScoreText;
    int lives = 3;
    private void Awake()
    {
        instance = this;
    }


    void Start()
    {

    }


    void Update()
    {

    }

    public void IncrementScore()
    {
        score++;
        ScoreText.text = score.ToString();
       // print(score);
    }

    public void DecrementLives()
    {
        {
            lives--;
            print(lives);   
        }
        if (lives <=0)
    {
        gameOver = true;
        GameOver();
     }
}
 
    public void GameOver()
    {
        print("Game Over");
    }

}
