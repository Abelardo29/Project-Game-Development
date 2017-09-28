using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCheck : MonoBehaviour {
    
    void OnBecameInvisible()
    {
        if (transform.position.x < Camera.main.gameObject.transform.position.x -10 || transform.position.y < Camera.main.gameObject.transform.position.y - 5)
        {
            
        }
    }
}
