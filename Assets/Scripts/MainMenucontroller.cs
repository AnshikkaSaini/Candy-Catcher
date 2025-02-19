using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenucontroller : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Game");
    }


    public void Exit ()
    {
        
    }
}
