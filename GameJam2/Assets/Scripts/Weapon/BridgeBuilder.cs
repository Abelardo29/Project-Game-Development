using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeBuilder : BuildMechanic {
    public float bridgeSizeModifier = 0.2f;
    public float turnSpeed = 5;
    GameObject CreateBridge;
    private Vector3 initialSize = new Vector3(0, 0.1f, 1);

    // Use this for initialization
    void Start () {
        turnSpeed *= 1000;
        CreateBridge = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Destroy(CreateBridge.GetComponent<BoxCollider>());        

        CreateBridge.transform.localScale = initialSize;
    }
	
	// Update is called once per frame
	public override void Update () {
        base.Update();
        CreateBridge.transform.position = Camera.main.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10f));

        if (Input.GetMouseButtonUp(0)) {

            CreateBridge.AddComponent<BoxCollider2D>();
            CreateBridge.AddComponent<Rigidbody2D>();

            Instantiate(CreateBridge);

            Destroy(CreateBridge.GetComponent<BoxCollider2D>());
            Destroy(CreateBridge.GetComponent<Rigidbody2D>());

            CreateBridge.transform.localScale = initialSize;
            CreateBridge.transform.rotation = Quaternion.identity;
        }

        if (Input.GetMouseButtonDown(1)) {
            CreateBridge.transform.localScale = initialSize;
            CreateBridge.transform.rotation = Quaternion.identity;

            return;
        }
        CreateBridge.transform.Rotate(0, 0, Input.GetAxis("Mouse ScrollWheel") * turnSpeed * Time.deltaTime);
    }

    protected override void CreateTerrain() {
        CreateBridge.transform.localScale += new Vector3(bridgeSizeModifier, 0, 0);        
    }
}