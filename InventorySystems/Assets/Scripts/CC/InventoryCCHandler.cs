using UnityEngine;

public class InventoryCCHandler : MonoBehaviour
{   
    [SerializeField] private Inventory inventory;
    
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

        ItemSO item = new WeaponSO();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // TODO: Make following if statements not hardcoded
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            gameObject.transform.Find("InventoryCC").gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            gameObject.transform.Find("InventoryCC").gameObject.SetActive(false);
        }
    }


}
