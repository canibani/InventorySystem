using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private InventoryEboHandler inventoryEboHandler;

    // Start is called before the first frame update
    void Start()
    {
        inventoryEboHandler = GetComponent<InventoryEboHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider) {
        if (collider.CompareTag("Item"))
        {   
            PickUpItem(collider.GetComponent<Item>().item);
            Destroy(collider.gameObject);
        }
    }

    private void PickUpItem(ItemSO item) {
        inventoryEboHandler.AddItem(item);
    }
}
