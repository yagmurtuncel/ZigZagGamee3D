using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundAndCoinSpawner : MonoBehaviour
{
    [SerializeField] GameObject sonZemin,coin,cylinder;

    private void Start()
    {
        for (int i = 1; i < 20; i++)
        {
            ZeminOlustur();
        }
    }
    public void ZeminOlustur()
    {
        Vector3 yon;

        if (Random.Range(0, 2) == 0)//0 gelirse x ekseninde zemin koy
        {
            yon = Vector3.left;
        }
        else//1 gelirse z eksninde zemin koy
        {
            yon = Vector3.back;
        }
        sonZemin = Instantiate(sonZemin, sonZemin.transform.position
            + yon, sonZemin.transform.rotation);
        CoinSpawner();
    }

    public void CoinSpawner()
    {
        if (Random.Range(0, 2) == 0)
        {
            Vector3 mekan = new Vector3(sonZemin.transform.position.x, sonZemin.transform.position.y + 1, sonZemin.transform.position.z);
            Instantiate(coin, mekan, Quaternion.identity);
        }
    }
}