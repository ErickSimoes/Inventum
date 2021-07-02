using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodItem", menuName = "Inventum/Food", order = 1)]
public class Food : Item {
    public int health;
    public float weight;
}
