using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceManager : MonoBehaviour {

    public int hp;
    public int wood;
    public int stone;
    public int food;

	// Use this for initialization
	void Start () {
        hp = 100;
        wood = 0;
        food = 0;
        stone = 0;
	}
	
	// Update is called once per frame
	void Update () {
        wood++;
	}
}
