using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBuilder : BuildMechanic {
    int bridgeNumber = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public override void Update () {
        base.Update();

	}

    protected override void CreateTerrain() {
        GameObject currentCreating = new GameObject("Bridge #" + bridgeNumber++);
        currentCreating.AddComponent<MeshFilter>();
        currentCreating.AddComponent<MeshRenderer>();

        currentCreating.transform.position = Input.mousePosition;
    }
}