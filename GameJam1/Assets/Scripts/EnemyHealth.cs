using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public float health;
	
	// Update is called once per frame
	void Update () {
		if (IsDead()) {
            //Playerpoints++;
            //Destroy it?
        }
	}

    bool IsDead() {
        return health < 0;
    }
}
