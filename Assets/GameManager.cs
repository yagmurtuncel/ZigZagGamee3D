using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject playGamePanel;
    public static bool isRestart = false;
    public void restartGame()
    {
        isRestart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void BackMenu()
    {
        playGamePanel.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
