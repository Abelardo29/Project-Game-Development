using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Harvest : MonoBehaviour {

    private float nIntervalHarvest;
    private float intervalHarvest = 1;
    private float totalHarvests = 10;

    private string resourceTypeCol;
	
    public void HarvestResource(float startTime)
    {
        intervalHarvest = startTime;
        if (nIntervalHarvest + intervalHarvest <= Time.time)
        {
            nIntervalHarvest += intervalHarvest;
            switch (resourceTypeCol)
            {
                case "Stone":
                    resourceTypeCol = "Stone";
                    //Add harvest code;
                    break;

                case "Wood":
                    resourceTypeCol = "Wood";
                    //Add harvest code;
                    break;
            }
        }
        if (nIntervalHarvest > startTime + (totalHarvests * intervalHarvest))
        {
            // switch state to travelHome;
            
        }
    }

    private void OnCollision(Collision collision)
    {
        if (collision.gameObject.tag == "Resource")
        {
            HarvestResource(Time.time);
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
