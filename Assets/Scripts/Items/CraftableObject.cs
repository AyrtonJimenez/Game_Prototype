using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Craftable Object", menuName = "Inventory System/Items/Craftable" )]
public class CraftableObject : ItemObject
{
    private void Awake()
    {
        type = ItemType.Craftable;
    }
}
