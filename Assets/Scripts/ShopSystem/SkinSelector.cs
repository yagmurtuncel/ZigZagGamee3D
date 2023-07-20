using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinSelector : MonoBehaviour
{
    public int currentModelIndex;
    public GameObject[] models;

    void Start()
    {
        currentModelIndex = PlayerPrefs.GetInt("SelectedModel", 0);
        foreach (GameObject model in models)
        {
            model.SetActive(false);
        }
        models[currentModelIndex].SetActive(true);
    }







}//class
