
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool isRestart = false;
    
    

    public void PlayGame()
    {

        isRestart = false;
        SceneManager.LoadScene("Game");
    }
    public void RestartGame()
    {
        isRestart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Shop()
    {
        SceneManager.LoadScene("ShopMenu");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
