using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBuilder : BuildMechanic {

    
	// Use this for initialization
	void Start () {
        name = "Rope";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected override void CreateTerrain() {
        throw new NotImplementedException();
    }
}
