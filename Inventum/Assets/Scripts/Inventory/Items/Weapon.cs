using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponItem", menuName = "Inventum/Weapon", order = 1)]
public class Weapon : Item {
    public int damage;
    public float weight;

    public override void Action() {
        
    }

}
