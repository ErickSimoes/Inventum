using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    
    void Start() {
        
    }

    
    void Update() {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
        print(hit.gameObject.name);
    }
}
