using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI score;
    private int currentScore;

    private void OnEnable()
    {
        UpdatePoints_GA.UpdateScore += UpdateScore;
        RespawnPlayer_GA.ResetScore += ResetScore;
    }
    private void OnDisable()
    {
        UpdatePoints_GA.UpdateScore -= UpdateScore;
        RespawnPlayer_GA.ResetScore -= ResetScore;
    }
    private void UpdateScore(int amount)
    {
        currentScore += amount;
        score.text = currentScore.ToString();        
    }
    private void ResetScore()
    {
        score.text = 0.ToString();
        currentScore= 0;
    }
}
