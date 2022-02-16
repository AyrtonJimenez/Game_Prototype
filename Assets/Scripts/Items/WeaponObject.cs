using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Object", menuName = "Inventory System/Items/Weapon")]

public class WeaponObject : ItemObject
{
    public int weaponDamage = 12;
    public int weaponType = 0;
    public int weaponRange = 5;

    public void Awake()
    {
        type = ItemType.Weapon;
    }
}
