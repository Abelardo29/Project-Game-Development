using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetResourceUI : MonoBehaviour {

    GameObject player;
    ResourceManager resources;
    public Text resourceText;
    void Start()
    {
        player = GameObject.Find("Player");
        resources = player.GetComponent<ResourceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        resourceText.text = "HP: " + 0 + "                 Food: " + resources.resources[resources.wheat] + "                 Wood: " + resources.resources[resources.wood] + "                 Stone: " + resources.resources[resources.stone];
    }
}
