using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {

    public GameObject player;
    public bool DayNightSwitch;

    [HideInInspector]
    public bool Night;

    private Light[] lights;

    // Use this for initialization
    void Start() {
        lights = FindObjectsOfType(typeof(Light)) as Light[]; // array with all lights in the scene
    }
    // Update is called once per frame
    void Update() {
        if (DayNightSwitch) {
            Night = !Night;
            if (Night) {
                foreach (Light light in lights) {
                    light.intensity = 2f; // turn on all lights in the scene
                }
                player.GetComponentInChildren<Light>().intensity = 0.5f; // turn player light down
            } else {
                foreach (Light light in lights) {
                    light.intensity = 0f; // turn off all lights in the scene
                }
                player.GetComponentInChildren<Light>().intensity = 1f; // turn player light on
            }
            DayNightSwitch = false;
        }
    }
}
