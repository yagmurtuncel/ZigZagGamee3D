using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Color[] colors;

    Color ikinciRenk;
    int birinciRenk;

    public Material zeminMat;

    private void Start()
    {
        birinciRenk = Random.Range(0, colors.Length);
        ikinciRenk = colors[IkinciRengiSec()];
        zeminMat.color = colors[birinciRenk];
        Camera.main.backgroundColor = colors[birinciRenk];
    }

    private void Update()
    {
        Color fark = zeminMat.color - ikinciRenk;

        if(Mathf.Abs(fark.r) + Mathf.Abs(fark.g) +Mathf.Abs(fark.b)<0.2f) //Mutlak değere döndürme 
        {
            ikinciRenk = colors[IkinciRengiSec()];
        }
        zeminMat.color = Color.Lerp(zeminMat.color, ikinciRenk, 0.003f); //Renk geçişi sağlama
        Camera.main.backgroundColor = Color.Lerp(Camera.main.backgroundColor, ikinciRenk, 0.0007f);
    }

    int IkinciRengiSec()
    {
        int ikinciRenkIndex;
        ikinciRenkIndex = Random.Range(0, colors.Length);

        while (ikinciRenkIndex == birinciRenk)
        {
            ikinciRenkIndex = Random.Range(0, colors.Length);
        }

        return ikinciRenkIndex;
    }



}//class
