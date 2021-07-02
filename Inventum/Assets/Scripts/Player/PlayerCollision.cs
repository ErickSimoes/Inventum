using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    [SerializeField]
    Inventory inventory;

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag == "Item") {
            inventory.AddItems(hit.gameObject.GetComponent<ItemComponent>().item);
            Destroy(hit.gameObject);
        }
    }
}
