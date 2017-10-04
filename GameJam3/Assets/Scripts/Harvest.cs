using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour {

    private GameObject harvestTarget;

    public float intervalHarvest = 1;
    public float totalHarvests = 10;
    private float harvests;
    private float startTime;

    private string resourceTypeCol;
	
    public void HarvestResource(string resource, string state)
    {
        if (state == "Harvesting")
        {
            // Code die de bepaalde resource toevoegd
            switch (resource)
            {
                case "Iron":
                    if (harvestTarget.GetComponent<Iron>().ironAmount <= 0)
                    {
                        // switch state to TravelHome na het maximum aantal harvests.
                        TravelHome();
                        break;
                    }
                    GetComponent<ResourceManager>().iron++;
                    break;
                case "Stone":
                    GetComponent<ResourceManager>().stone++;
                    break;
                case "Wheat":
                    GetComponent<ResourceManager>().wheat++;
                    break;
                case "Wood":
                    GetComponent<ResourceManager>().wood++;
                    break;
            }
        }
    }

    private void TravelHome()
    {
        // switch state to TravelHome na het maximum aantal harvests.
        GetComponent<VillagerStateManager>().state = "TravelHome";
    }

    private void Update()
    {
        // na elk interval harvest de villager 1 resource van het type.
        if (Time.time >= (startTime + intervalHarvest))
        {
            harvests++;
            startTime += intervalHarvest;
            HarvestResource(harvestTarget.GetComponent<ResourceType>().resourceType, GetComponent<VillagerStateManager>().state);
        }
        if (harvests >= totalHarvests)
        {
            TravelHome();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Geeft de begintijd en type rescource door aan de update.
        if (collision.gameObject.tag == "Resource")
        {
            startTime = Time.time;
        }
        harvestTarget = collision.gameObject;        
    }
}
