using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Power {Speed, Immunity}

[CreateAssetMenu(fileName = "PowerUpItem", menuName = "Inventum/PowerUp", order = 1)]
public class PowerUp : Item {
    public Power power;
}
