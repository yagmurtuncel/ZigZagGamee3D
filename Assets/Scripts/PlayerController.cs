using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Header("Out Component")]
    [SerializeField] float speed;
    [SerializeField] Text scoreText, bestScoreText,startPanelBestScoreText,restartPanelBestScoreText, coinText;
    [SerializeField] GameObject restartPanel;
    [SerializeField] Animator panelAnim;

    [Header("Public Variable")]
    public GroundAndCoinSpawner groundAndCoinSpawner;
    public static bool isDead = false;
    public float hizlanmaZorlugu;
    bool beatHighScore;
    Vector3 yon = Vector3.left;
    int bestScore;
    float coin;
    public float score = 0f;
    



    private void Start()
    {
        if(GameManager.isRestart)
        {
            isDead = false;
            
        }

        bestScore = PlayerPrefs.GetInt("BestScore");
        startPanelBestScoreText.text = "Best Score: " + bestScore.ToString();

        coin = PlayerPrefs.GetInt("Coins");
        coinText.text = "Coins: " + coin.ToString();

       
    }

    private void Update()
    {
        if(isDead)
        {
            return;
        }

        bestScoreText.text = "Best: " + bestScore.ToString();
        if (bestScore < score)
        {
            bestScore = (int)score;
            PlayerPrefs.SetInt("BestScore", bestScore);
            bestScoreText.text = "Best: " + bestScore.ToString();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(yon.x==0)//z ekseninde hareket ediyor demektir
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.back;
            }
        }

        if(transform.position.y< 0.1f)
        {
            isDead = true;
            restartPanelBestScoreText.text = "Best Score: " + bestScore.ToString();
            restartPanel.SetActive(true);
            Destroy(this.gameObject, 3f);
        }
        Debug.Log("Hız: " + speed + "katsayı: " + hizlanmaZorlugu);
    }

    private void FixedUpdate()
    {
        if(isDead)
        {
            return;
        }

        Vector3 hareket = yon * speed * Time.deltaTime; //objemizin hareket değeri
        speed += Time.deltaTime * hizlanmaZorlugu;
        transform.position += hareket; //hareket değerini sürekli pozisyonuma ekle

        scoreText.text = "Score: "+ ((int) score).ToString();
        coinText.text="Coins:" + ((int)coin).ToString();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Zemin"))
        {
            StartCoroutine(YokEt(collision.gameObject));
            groundAndCoinSpawner.ZeminOlustur();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            
            CoinCollecting(other);
            coin += 5;
            
        }
    }

    IEnumerator YokEt(GameObject zemin)
    {
        yield return new WaitForSeconds(0.2f);
        zemin.AddComponent<Rigidbody>();

        yield return new WaitForSeconds(0.4f);
        Destroy(zemin);
    }

    

    void CoinCollecting(Collider other)
    {
        score += 5;
        
        Destroy(other.gameObject);
        SpeedIncreaser();
        if(PlayerPrefs.GetInt("BestScore") < score && !beatHighScore)
        {
            beatHighScore = true;
            panelAnim.SetTrigger("HighScore");
        }
        

    }

    void SpeedIncreaser()
    {
        if(score % 30 == 0)
        {
            hizlanmaZorlugu += 0.01f;
        }
    }
}//class
