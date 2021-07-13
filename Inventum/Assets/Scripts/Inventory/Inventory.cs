using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory", menuName = "Inventum/Inventory", order = 0)]
public class Inventory : ScriptableObject {
    
    public List<Item> items = new List<Item>();

    public void AddItems(Item item) {
        items.Add(item);
        ShowItems();
    }

    public void ShowItems() {
        foreach (Item item in items) {
            Debug.Log($"{item.type} - {item.title}");
        }
    }

    public void RemoveItem(Item item) {
        items.Remove(item);
        ShowItems();
    }

}
