using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    [SerializeField] private GameObject selectedSkin;
    [SerializeField] private Text coinsText;
    [SerializeField] private SkinManager skinManager;

    void Update()
    {
        coinsText.text = "Coins: " + PlayerPrefs.GetInt("Coins");
        selectedSkin = skinManager.GetSelectedSkin().ball;
    }

    public void LoadMenu() => SceneManager.LoadScene("MainMenuScene");
}
