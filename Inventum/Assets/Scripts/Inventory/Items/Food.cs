using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "FoodItem", menuName = "Inventum/Food", order = 1)]
public class Food : Item {
    public int health;
    public float weight;

    public override void Action() {
        
        if (!player) {
            player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        player.health += this.health;

        if (!inventory) {
            inventory = FindObjectOfType<InventoryComponent>().inventory;
        }

        inventory.RemoveItem(this);
    }
}
