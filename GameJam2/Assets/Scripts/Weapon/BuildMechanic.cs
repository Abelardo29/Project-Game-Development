using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  abstract class BuildMechanic : MonoBehaviour {
    [HideInInspector()]
    string name;    

    public virtual void UpdateAttachment() {
        if (Input.GetMouseButton(0)) {
            CreateTerrain();        
        }
    }

    protected abstract void CreateTerrain();
}
