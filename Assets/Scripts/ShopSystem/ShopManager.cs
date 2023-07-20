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


    public void ChangeNext ()
    {
        pModels[currentModelIndex].SetActive(false);
        currentModelIndex++;

        if(currentModelIndex == pModels.Length)
        {
            currentModelIndex = 0;
        }
        pModels[currentModelIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedModel", currentModelIndex);
    }
    public void ChangePrevious ()
    {
        pModels[currentModelIndex].SetActive(false);
        currentModelIndex--;

        if(currentModelIndex == -1)
        {
            currentModelIndex = pModels.Length -1;
        }
        pModels[currentModelIndex].SetActive(true);
        PlayerPrefs.SetInt("SelectedModel", currentModelIndex);
    }


}//class
