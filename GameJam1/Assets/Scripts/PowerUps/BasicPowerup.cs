using UnityEngine;

public abstract class BasicPowerup : MonoBehaviour {

    //Dit is de blauwdruk voor alle powerups, hierdoor kunnen we regelen wie wat heeft.
    public void Start() {
        Equip();
    }

    public abstract void Equip();//dit verandert stats zodra het wordt opgepakt.

    public abstract void DeEquip();//dit draait die stats weer terug de persoon een andere disuise pakt/die van hem kwijtraakt.
}
