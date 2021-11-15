using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ArmorSO", menuName = "InventorySystems/ArmorSO")]
public class ArmorSO : ItemSO {
    public Type type;
    public enum Type {
        Helmet,
        Platebody,
        Platelegs
    }
}