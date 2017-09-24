using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class BuildMechanic : MonoBehaviour {

    public virtual void Update() {
        if (Input.GetMouseButton(0)) {
            CreateTerrain();        
        }
    }

    protected abstract void CreateTerrain();
}
