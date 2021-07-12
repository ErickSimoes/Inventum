using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryComponent : MonoBehaviour {
    
    public Inventory inventory;
    public GameObject itemButton;

    void Start() {
        GameObject recentItem;
        foreach (Item item in inventory.items) {
            recentItem = Instantiate(itemButton, this.transform);
            recentItem.GetComponent<Image>().sprite = item.icon;
        }
    }

    void Update() {
        
    }
}
