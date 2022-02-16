using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;

    public int xBetweenItems;
    public int numberOfColumns;
    public int yBetweenItems;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();

    void Start()
    {
        CreateDisplay();    
    }

    void Update()
    {
        UpdateDisplay();    
    }

    public void CreateDisplay()
    {
        for(int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventory.Container[i].item.prefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            obj.GetComponentInChildren<TextMeshProUGUI>().text = inventory.Container[i].amount.ToString("n0");
        }
    }

    public Vector3 GetPosition(int i)
    {
        return new Vector3(xBetweenItems * (i % numberOfColumns), (-yBetweenItems * (i / numberOfColumns)), 0f);
    }

    public void UpdateDisplay()
    {

    }
}

