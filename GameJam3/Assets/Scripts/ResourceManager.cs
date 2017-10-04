using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour {

    public int iron = 0;
    public int stone = 1;
    public int wheat = 2;
    public int wood = 3;
    public int[] resources = new int[4];

    private GameObject colBuilding;

    //stores items on contact with building
	
    private void Store (int resourceType)
    {
        for (int i = resources[resourceType]; i > 0; i--)
        {
            resources[resourceType]--;
            colBuilding.GetComponent<ResourceManager>().resources[resourceType]++;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Building")
        {
            GetComponent<VillagerStateManager>().state = "MoveTarget";
            colBuilding = collision.gameObject;

            Store(iron);
            Store(stone);
            Store(wheat);
            Store(wood);
        }
    }
}
