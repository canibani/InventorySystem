using UnityEngine;

[CreateAssetMenu(fileName = "ItemSO", menuName = "InventorySystems/ItemSO")]
public class ItemSO : ScriptableObject {

    [SerializeField] private string itemName;
    [SerializeField] private Sprite sprite;
    
    public string ItemName { 
        get {
            return itemName;
        }
    }
    
    public Sprite Sprite {
        get {
            return sprite;
        }
    }
}
