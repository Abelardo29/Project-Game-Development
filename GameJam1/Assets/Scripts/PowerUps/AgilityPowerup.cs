using UnityEngine;
public class AgilityPowerup : BasicPowerup {

    GameObject owner;

    public AgilityPowerup(GameObject owner) {
        this.owner = owner;
    }

    public float jumpModifier = 2f, moveSpeedModifier = 1.3f;

    public override void Equip() {//allemaal super simpel nog want ik weet niet hoe de player class er precies uitziet.
        //owner.jumpForce *= jumpModifier;
        //owner.movementSpeed *= moveSpeedModifier;
    }

    public override void DeEquip() {
        //owner.jumpForce = (owner.jumpForce / jumpModifier) * 1;
        //owner.movementSpeed = (owner.movementSpeed / moveSpeedModifier) * 1;
    }

}
