﻿using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.

    void Start() {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Update() {
        // If the enemy and the player have health left...
        if (enemyHealth.health > 0 && playerHealth.health > 0) {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
        }
        // Otherwise...
        else {
            // ... disable the nav mesh agent.
            nav.enabled = false;
        }
    }
}