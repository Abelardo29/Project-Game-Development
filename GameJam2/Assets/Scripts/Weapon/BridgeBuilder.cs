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
        GameObject CreateBridge = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Instantiate(CreateBridge);
        
        CreateBridge.AddComponent<MeshFilter>();
        CreateBridge.AddComponent<MeshRenderer>();

        CreateBridge.transform.position = Input.mousePosition;
    }
}