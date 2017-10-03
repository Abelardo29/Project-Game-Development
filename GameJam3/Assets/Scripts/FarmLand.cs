using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmLand : MonoBehaviour {

    public bool Growing;
    public float GrowthCooldown;
    public bool Harvest;
    private float growthTimer;

	void Start () {
        growthTimer = 0;
        gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.3f, 0.2f);
    }
	
	void Update () {
        if (Growing) { // if farm is next to farmland
            growthTimer += Time.deltaTime;
            gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.3f, 0.2f);

            if (growthTimer > GrowthCooldown) { // done growing
                gameObject.GetComponent<Renderer>().material.color = new Color(0.8f, 0.8f, 0.1f);

                if (Harvest) { // harvest
                    growthTimer = 0;
                    Harvest = false;
                }
            }
        }
	}
}
