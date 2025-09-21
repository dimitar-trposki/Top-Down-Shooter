using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score;
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }
}