using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    // Variable to track the player position.
    public Transform player;
    // Variable to track the current enemy position.
    private NavMeshAgent navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // If player is still alive
        if (player != null)
        {
            // Set the enemy to seek the players position.
            navMeshAgent.SetDestination(player.position);
        }
    }
}
