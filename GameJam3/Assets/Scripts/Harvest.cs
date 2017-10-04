using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour {

    public float intervalHarvest = 1;
    public float totalHarvests = 10;
    private float harvests;
    private float startTime;

    private string resourceTypeCol;
	
    public void HarvestResource(string resource)
    {
        switch (resource)
        {
            case "Stone":
                // stone++
                break;
            case "Wood":
                // wood++
                break;
        }
    }
    private void Update()
    {
        if (Time.time >= (startTime + intervalHarvest))
        {
            harvests++;
            startTime += intervalHarvest;
            HarvestResource(resourceTypeCol);
        }
        if (harvests >= totalHarvests)
        {
            // switch state to travelHome;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Resource")
        {
            startTime = Time.time;
        }
        switch (collision.gameObject.GetComponent<ResourceType>().resourceType)
        {
            case "Stone":
                resourceTypeCol = "Stone";
                break;

            case "Wood":
                resourceTypeCol = "Wood";
                break;
        }
    }
}
