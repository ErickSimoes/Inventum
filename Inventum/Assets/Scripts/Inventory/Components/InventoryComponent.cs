using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryComponent : MonoBehaviour {
    
    public Inventory inventory;
    public GameObject itemButton;

    void OnEnable() {
        GameObject recentItem;
        foreach (Item item in inventory.items) {
            recentItem = Instantiate(itemButton, this.transform);
            recentItem.GetComponent<Image>().sprite = item.icon;
        }
    }

    void OnDisable() {
        Component[] items = GetComponentsInChildren(typeof(Button), true);
        foreach (Component item in items) {
            Destroy(item.gameObject);
        }
    }
}
