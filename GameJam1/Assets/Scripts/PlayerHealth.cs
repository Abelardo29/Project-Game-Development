using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public float health;

    void Update() {
        if (IsDead()) {
            //do something, idk.
            MonoBehaviour.Destroy(this);//dit verwijdert alleen het script, niet het object zelf helaas.
        }
    }

    bool IsDead() {
        return health < 0;
    }
    
}
