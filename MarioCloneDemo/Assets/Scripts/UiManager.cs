using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class UiManager : MonoBehaviour
{

    private int currentScore = 0;
    public static UiManager Instance = null;
    [SerializeField] TextMeshProUGUI pointText;

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
}
