using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    private int health = 100;
    public TMP_Text scoreText;
    [SerializeField] GameObject panel;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ChangeHealth(int amount)
    {
        health -= amount;
        scoreText.text = "Health: " + health + "%";
        if (health == 0)
        {
            scoreText.text = "Health: " + 0 + "%";
            panel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}