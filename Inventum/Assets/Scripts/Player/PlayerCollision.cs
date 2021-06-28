using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    Inventory inventory;

    void Start() {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

        if (!inventory) {
            Debug.LogError("Inventory is not found!");
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag == "Item") {
            print("Bati em um item");
        }
    }
}
