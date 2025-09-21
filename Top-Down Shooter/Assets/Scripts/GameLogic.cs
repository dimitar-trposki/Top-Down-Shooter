using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public GreenSpawner greenSpawner;
    public RedSpawner redSpawner;
    public int levelId;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (levelId == 1)
        {
            InvokeRepeating("CreateEnemyGreen", 2, 2);
        }
        else
        {
            InvokeRepeating("CreateEnemyGreen", 3, 3);
            InvokeRepeating("CreateEnemyRed", 5, 7);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void CreateEnemyGreen()
    {
        greenSpawner.SpawnGreen();
    }

    void CreateEnemyRed()
    {
        redSpawner.SpawnRed();
    }
}