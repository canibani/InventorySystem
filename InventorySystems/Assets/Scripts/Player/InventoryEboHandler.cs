using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryEboHandler : MonoBehaviour
{
    [SerializeField] private Inventory inventory;

    private void Start() {
    }
    
    public void AddItem(ItemSO item) {
        inventory.AddItem(item);
    }
}
