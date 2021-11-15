using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInventory : MonoBehaviour
{   
    [SerializeField] private GameObject inventoryEbo;
    private bool inventoryOpen = false;
    private void OnOpenInventory() {
        if (inventoryOpen == false) {
            inventoryOpen = true;
        } else {
            inventoryOpen = false;
        }
        inventoryEbo.SetActive(inventoryOpen);
    }
}
