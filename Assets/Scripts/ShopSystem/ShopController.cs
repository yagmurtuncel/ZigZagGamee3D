using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopController : MonoBehaviour
{
    [SerializeField] private Image selectedSkin;
    [SerializeField] private Text coinsText;
    [SerializeField] private SkinManager skinManager;
    float coin;
    float score;
    

    void Update()
    {
        coin = score;
        PlayerPrefs.SetInt("Coins", (int)coin);
        selectedSkin.sprite = skinManager.GetSelectedSkin().sprite;
    }

    
}
