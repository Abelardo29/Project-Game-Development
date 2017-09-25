using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour {//Gemaakt door Jan van Popta.
    //Dit is de klasse die weaponswitches regelt.


    public BridgeBuilder bridgeAttachment;
    
    [HideInInspector()]
    List<BuildMechanic> attachments = new List<BuildMechanic>();


    //Start () hier controleert welke attachments we aan het wapen hebben gegeven, zo houden we capaciteiten van de speler modulair.
    void Start () {
        if (bridgeAttachment != null)
            attachments.Add(bridgeAttachment);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
