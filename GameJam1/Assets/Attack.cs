/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Mouse.LeftButton == MouseButtonState.Pressed && CanHitEnemy)
        {

        }

    }

    public bool CanHitEnemy()
    {

        RaycastHit hit;
        Vector3 rayDirection = transform.forward;
        
        if (Physics.Raycast(transform.position, rayDirection, out hit, 50f))
        { 
            if (hit.transform.tag == "Enemy")
            {
                return true;
            }
        }
        return false;
    }
}*/
