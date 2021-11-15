using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryDisplayHandler : MonoBehaviour
{
    [SerializeField] private Inventory inventory;
    [SerializeField] private GameObject inventorySlot;
    [SerializeField] private GameObject itemContainer;
    [SerializeField] private int X_MARGIN = 10;
    [SerializeField] private int Y_MARGIN = 10;

    private List<GameObject> slots;
    // Start is called before the first frame update
    void Start()
    {
        itemContainer = gameObject.transform.Find("Canvas/ItemContainer").gameObject;
        slots = new List<GameObject>();
        CreateSlots();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateItems();
    }

    private void CreateSlots() {
        int amountOfSlots = inventory.itemSlots.Count;
        for (int i = 0;i < amountOfSlots;i++) {
            CreateSlot(i);
        }
    }
    private void UpdateItems(){
        List<ItemSlot> items = inventory.itemSlots;
        for (int i = 0; i < items.Count; i++) {
            Debug.Log(items[i].GetItem().ItemName);
            Debug.Log(items[i].GetItem().Sprite);
            slots[i].GetComponent<SpriteRenderer>().sprite = items[i].GetItem().Sprite;
        }
    } 

    private void CreateSlot(int index) {

        var slot = Instantiate(inventorySlot, Vector3.zero, Quaternion.identity);
        slot.transform.SetParent(itemContainer.transform);
        slot.transform.localPosition = new Vector3(X_MARGIN + (index * 100 + index * X_MARGIN) - 800, Y_MARGIN + 250, 0f);
    	slots.Add(slot);
    }
}
