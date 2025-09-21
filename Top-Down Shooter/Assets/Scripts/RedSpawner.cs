using UnityEngine;

public class RedSpawner : MonoBehaviour
{
    public GameObject redEnemyPrefab;

    public GameObject player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SpawnRed()
    {
        GameObject enemy = Instantiate(redEnemyPrefab);

        enemy.transform.position = transform.position;

        enemy.name = "EnemyRed";

        enemy.GetComponent<RedEnemy>().player = player;
    }
}