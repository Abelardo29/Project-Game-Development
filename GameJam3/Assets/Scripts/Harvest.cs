using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour {

    private GameObject harvestTarget;
    private ResourceManager rsm;

    public float intervalHarvest = 1;
    public float totalHarvests = 10;
    private float harvests;
    private float startTime;

    private string resourceTypeCol;

    private void Start()
    {
        rsm = GetComponent<ResourceManager>();
    }

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
                    rsm.resources[rsm.iron]++;
                    harvestTarget.GetComponent<Iron>().ironAmount--;
                    break;
                case "Stone":
                    rsm.resources[rsm.stone]++;
                    break;
                case "Wheat":
                    rsm.resources[rsm.wheat]++;
                    break;
                case "Wood":
                    rsm.resources[rsm.wood]++;
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
        if (GetComponent<VillagerStateManager>().state == "Harvesting")
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
                harvests = 0;
            }
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
