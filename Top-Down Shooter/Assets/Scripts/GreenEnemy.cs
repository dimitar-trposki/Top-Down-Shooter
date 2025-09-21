using System;
using UnityEngine;
using UnityEngine.AI;

public class GreenEnemy : MonoBehaviour
{
    NavMeshAgent agent;

    public GameObject player;

    private Score scoreScript; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        
        scoreScript = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) > 0.75f)
        {
            agent.SetDestination(player.transform.position);
        }
        else
        {
            agent.SetDestination(transform.position);
        }
    }

    public void OnDestroy()
    {
        scoreScript.ChangeScore(10);
    }
}