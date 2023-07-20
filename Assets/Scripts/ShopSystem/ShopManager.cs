using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currentModelIndex;
    public GameObject[] pModels;

    void Start()
    {
        currentModelIndex = PlayerPrefs.GetInt("SelectedModel", 0);
        foreach (GameObject model in pModels) 
        { 
            model.SetActive(false);
        }

        pModels[currentModelIndex].SetActive(true);
    }

   
    void Update()
    {
        
    }
}
