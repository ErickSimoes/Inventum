using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour {
    
    [SerializeField]
    Canvas InventoryCanvas;

    void Update() {
        if (Input.GetKeyUp(KeyCode.I)) {
            InventoryCanvas.gameObject.SetActive(!InventoryCanvas.gameObject.activeSelf);
        }
    }
}
