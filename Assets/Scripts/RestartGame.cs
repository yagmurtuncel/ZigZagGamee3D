using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] GameObject shopPanel, playGamePanel;
    public static bool isRestart = false;
    public void restartGame()
    {
        isRestart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Shop()
    {
        shopPanel.SetActive(true);
    }
    public void BackMenu()
    {
        playGamePanel.SetActive(true);
        shopPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }















}//class
