using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class UiManager : MonoBehaviour
{

    private int currentScore = 0;
    private int playerHP = 5;
    public static UiManager Instance = null;
    [SerializeField] TextMeshProUGUI pointText;
    [SerializeField] TextMeshProUGUI hpText;
    [SerializeField] GameObject winText;
    [SerializeField] GameObject winButton;

    [SerializeField] int enemyCount = 2;
    [SerializeField] int coinCount = 3;
    

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } 
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int points)
    {
        currentScore += points;
        pointText.text = "x" + currentScore.ToString();
    }

    public void decreaseHP(int hitPoints)
    {
        playerHP -= hitPoints;
        hpText.text = playerHP.ToString() + "/5 HP";
        if (playerHP == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    
    public void KillCoin()
    {
        coinCount--;
        CheckEndGame();
    }

    public void killEnemy()
    {
        enemyCount--;
        CheckEndGame();
    }

    private void CheckEndGame()
    {
        Debug.Log(enemyCount.ToString() + coinCount.ToString());
        if (enemyCount == 0 && coinCount == 0)
        {
            Debug.Log("Trying");
            winText.SetActive(true);
            winButton.SetActive(true);
        }
    }

    public void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
