using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGuard : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /*public bool CanSeePlayer() {

            var hit : RaycastHit;
            var rayDirection = playerObject.transform.position - transform.position;

            if (Physics.Raycast(transform.position, rayDirection, hit)) { // If the player is very close behind the player and in view the enemy will detect the player
                if ((hit.transform.tag == "Player") & amp; &amp; (distanceToPlayer & lt;= minPlayerDetectDistance)){
                    return true;
                }
            }

            if ((Vector3.Angle(rayDirection, transform.forward)) & lt; fieldOfViewRange){ // Detect if player is within the field of view
                if (Physics.Raycast(transform.position, rayDirection, hit)) {

                    if (hit.transform.tag == "Player") {
                        //Debug.Log("Can see player");
                        return true;
                    }
                    else {
                        //Debug.Log("Can not see player");
                        return false;
                    }
                }
            }
        }*/
}
