using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    void Start() {
        
    }

    
    void Update() {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.tag == "Item") {
            print("Bati em um item");
        }
    }
}
