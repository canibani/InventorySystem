using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory")]
public class Inventory : ScriptableObject {
    public List<ItemSlot> itemSlots = new List<ItemSlot>();

    // AddItem depends on whatever the designers want
    public void AddItem(ItemSO item) {
        ItemSlot itemSlot = new ItemSlot(item, 1);
        itemSlots.Add(itemSlot);

        // Check if item is stackable
            // Check if item is in the itemslots list
                // True = Amount++;
                // False = continue
        // Check if inventory has a free slot
            // Add item to inventory in the first available free spot
    }
}

[System.Serializable]
public class ItemSlot {
    [SerializeField] private ItemSO item;
    [SerializeField] private int amount;

    public ItemSlot(ItemSO item, int amount) {
        this.item = item;
        this.amount = amount;
    }

    public ItemSO GetItem() { return item; }
    public int GetAmount() { return amount; }
}