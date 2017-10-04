﻿using System.Collections;
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
        // Code die de bepaalde resource toevoegd
        switch (resource)
        {
            case "Iron":
                GetComponent<VillagerStateManager>().iron++;
                break;
            case "Stone":
                GetComponent<VillagerStateManager>().stone++;
                break;
            case "Wheat":
                GetComponent<VillagerStateManager>().wheat++;
                break;
            case "Wood":
                GetComponent<VillagerStateManager>().wood++;
                break;
        }
    }
    private void Update()
    {
        // na elk interval harvest de villager 1 resource van het type.
        if (Time.time >= (startTime + intervalHarvest))
        {
            harvests++;
            startTime += intervalHarvest;
            HarvestResource(resourceTypeCol);
        }
        if (harvests >= totalHarvests)
        {
            // switch state to TravelHome na het maximum aantal harvests.
            GetComponent<VillagerStateManager>().state = "TravelHome";
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Geeft de begintijd en type rescource door aan de update.
        if (collision.gameObject.tag == "Resource")
        {
            startTime = Time.time;
        }
        switch (collision.gameObject.GetComponent<ResourceType>().resourceType)
        {
            case "Iron":
                resourceTypeCol = "Iron";
                if (collision.gameObject.GetComponent<Iron>().IronAmount <= 0)
                {
                    // add "this is depleted"

                }
                break;
            case "Stone":
                resourceTypeCol = "Stone"; break;
            case "Wheat":
                resourceTypeCol = "Wheat";  break;
            case "Wood":
                resourceTypeCol = "Wood"; break;
        }
    }
}
