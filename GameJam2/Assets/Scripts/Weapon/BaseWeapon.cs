using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseWeapon : MonoBehaviour {//Gemaakt door Jan van Popta.
    //Dit is de klasse die weaponswitches regelt.

    public Canvas userInterface;
    public BridgeBuilder bridgeAttachment;
    public RopeBuilder ropeAttachment;

    private BuildMechanic currentAttachment;

    [HideInInspector()]
    List<BuildMechanic> attachments = new List<BuildMechanic>();


    //Start () hier controleert welke attachments we aan het wapen hebben gegeven, zo houden we capaciteiten van de speler modulair.
    void Start () {
        if (bridgeAttachment != null) 
            attachments.Add(bridgeAttachment);        
            

        if (ropeAttachment != null) {
            attachments.Add(ropeAttachment);
        }

        foreach(BuildMechanic current in attachments) {
            currentAttachment = current;
            return;
        }
	}
	
	// Update is called once per frame
	void Update () {
        var nextIndex = attachments.IndexOf(currentAttachment) + 1;

        if (Input.GetKeyDown(KeyCode.Q)) {
            currentAttachment = GetMechanic(-1);
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            currentAttachment = GetMechanic(1);
        }

        currentAttachment.UpdateAttachment();
	}

    public BuildMechanic GetMechanic(int relativePlace) {
        BuildMechanic previousAttachment = currentAttachment;

        var nextIndex = attachments.IndexOf(currentAttachment) + relativePlace;
       string previous = ("Previous equipment: " + previousAttachment.name + "\n");
        
        BuildMechanic returnObject;

        if (nextIndex == attachments.Count) 
            returnObject = attachments[0];

        else if (nextIndex == -1) 
            returnObject = attachments[attachments.Count - 1];    
            
        else         
            returnObject = attachments[nextIndex];
        userInterface.GetComponentInChildren<Text>().text = previous + "Current equipment: " + returnObject.name;
        return returnObject;
    }       
}
