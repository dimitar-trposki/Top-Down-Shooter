using UnityEngine;
using UnityEngine.VFX;

public class GreenSpawner : MonoBehaviour
{
    public GameObject greenEnemyPrefab;
    
    public GameObject player;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnGreen()
    {
        GameObject enemy = Instantiate(greenEnemyPrefab);
        
        enemy.transform.position = transform.position;

        enemy.name = "EnemyGreen";

        enemy.GetComponent<GreenEnemy>().player = player;
    }
}
