using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponSO", menuName = "InventorySystems/WeaponSO")]
public class WeaponSO : ItemSO {
    public Type type;
    public enum Type {
        Bow,
        Sword,
        Gun
    }
}