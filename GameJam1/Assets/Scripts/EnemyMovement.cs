using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    // Use this for initialization
    Rigidbody rb;
    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth me;        // Reference to this enemy's health.
    NavMeshAgent nav;               // Reference to the nav mesh agent.
    [HideInInspector()]
    public bool chasing;

    void Start() {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        me = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        chasing = false;
    }


    void Update() {
        if (chasing) {
            // Als we nog hp hebben en de speler nog leeft
            if (me.health > 0 && playerHealth.health > 0) {
                nav.SetDestination(player.position);
            } else {
                nav.enabled = false;
            }
        }
    }
}
