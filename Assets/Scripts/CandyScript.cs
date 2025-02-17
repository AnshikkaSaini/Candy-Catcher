using UnityEngine;

public class CandyScript : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.IncrementScore();  //Incrementing Score
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("Boundary"))
        {
            GameManager.instance.DecrementLives();  //Decrementing Lives
            Destroy(gameObject);
        }
    }
}
