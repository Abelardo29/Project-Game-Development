using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelCheck : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OncollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "GameController")
        {
            
            SceneManager.LoadScene(1);
        }
    }
}
