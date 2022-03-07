using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Default,
    Weapon,
    Consumable,
    Craftable,
}

public abstract class ItemObject : ScriptableObject
{
    public GameObject prefab;

    public ItemType type;

    [TextArea(15,20)]
    public string Description;
}
