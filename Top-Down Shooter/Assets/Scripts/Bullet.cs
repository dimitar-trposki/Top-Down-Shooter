using UnityEngine;

public class Bullets : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("EnemyGreen") || collision.gameObject.name.Contains("EnemyRed"))
        {
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }
}