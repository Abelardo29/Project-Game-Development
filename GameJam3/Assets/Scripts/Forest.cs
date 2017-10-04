using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forest : MonoBehaviour {

    public bool Growing;
    public float GrowthCooldown;
    public bool Harvest;
    private float growthTimer;

    void Start () {
        growthTimer = 0;
    }
	
	void Update () {
        if (Growing) { // if forest is next to lumberyard
            growthTimer += Time.deltaTime;
            gameObject.GetComponent<Renderer>().material.color = new Color(0.5f, 0.3f, 0.2f);

            if (growthTimer > GrowthCooldown) { // done growing
                gameObject.GetComponent<Renderer>().material.color = new Color(0.05f, 0.45f, 0.15f);

                if (Harvest) { // harvest
                    growthTimer = 0;
                    Harvest = false;
                }
            }
        }
    }
}
