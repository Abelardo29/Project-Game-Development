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
        resourceText.text = "HP: " + resources.hp + "                 Food: " + resources.food + "                 Wood: " + resources.wood + "                 Stone: " + resources.stone;
    }
}
