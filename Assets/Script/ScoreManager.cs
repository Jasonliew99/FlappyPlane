using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int CurrentScore = 0;

    public object Score { get; internal set; }

    public void AddScore(int scoreAmount)
    {
        CurrentScore += scoreAmount;
        Debug.Log("Current Score = " + CurrentScore);
    }
}
