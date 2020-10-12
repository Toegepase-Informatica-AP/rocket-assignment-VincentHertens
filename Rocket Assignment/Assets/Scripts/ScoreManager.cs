using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI gameOverScoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        SetScore();
    }

    void SetScore()
    {
        if (scoreText)
        {
            scoreText.text = score.ToString();
            gameOverScoreText.text = score.ToString();
        }
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        SetScore();
    }

    public int GetScore()
    {
        return score;
    }
}
