using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyVision : MonoBehaviour {

    public EnemyMovement movement;
    //we geven gewoon de hele player aan de vision klas, want waarom niet?
    //Het is fucking 2 uur 's nachts dus aantal fucks gaat het raam uit.
    GameObject player;
    //[SerializeField]CapsuleCollider visionCone;//not really a cone but whatever
    public LineRenderer visionLine = new LineRenderer();
    public float range;


    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        DrawLine(transform.position, new Vector3(transform.position.x, transform.position.y, range), Color.red, 500);
    }
	
	// Update is called once per frame
	void Update () {
        if (CanSeePlayer()) {
            movement.chasing = true;
        }
        
	}

    public bool CanSeePlayer() {

        RaycastHit hit;
        //player.transform.position - transform.position;
        Vector3 rayDirection = transform.forward; 
            if (Physics.Raycast(transform.position, rayDirection, out hit)) { // If the player is very close behind the player and in view the enemy will detect the player
                if (hit.transform.tag == "Player"){//korte notitie dat dit dus alleen recht voor zich kijkt atm.
                    return true;
                }
            }

            /*if ((Vector3.Angle(rayDirection, transform.forward)) & lt; fieldOfViewRange){ // Detect if player is within the field of view
                if (Physics.Raycast(transform.position, rayDirection, hit)) {

                    if (hit.transform.tag == "Player") {
                        Debug.Log("Can see player");
                        return true;
                    }
                    else {
                        Debug.Log("Can not see player");
                        return false;
                    }
                }
            }*/
        return false;
        }

    void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f) {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.startColor = color;
        lr.endColor =  color;
        lr.startWidth = 0.1f;
        lr.endWidth = 0.1f;
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        GameObject.Destroy(myLine, duration);
    }
}
