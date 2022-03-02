using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    private List<IPickAble> inventoryItems;

    public void AddItem(IPickAble item)
    {
        inventoryItems.Add(item);
    }

    public bool CheckItem(IPickAble item)
    {
        return inventoryItems.Contains(item);
    }
    public bool CheckItem(int itemID)
    {
        foreach (IPickAble item in inventoryItems)
        {
            if (item.ID == itemID) { return true; }
        }
        return false;
    }
    public bool CheckItem(string itemName)
    {
        foreach (IPickAble item in inventoryItems)
        {
            if (item.name == itemName) { return true; }
        }
        return false;
    }

    public bool DeleteItem(IPickAble item)
    {
        if (inventoryItems.Contains(item))
        {
            inventoryItems.Remove(item);
            return true;
        }
        return false;
    }

    public bool DeleteItem(int itemID)
    {
        foreach (IPickAble item in inventoryItems)
        {
            if (item.ID == itemID) {
                inventoryItems.Remove(item);
                return true; 
            }
        }
        return false;
    }
    public bool DeleteItem(string itemName)
    {
        foreach (IPickAble item in inventoryItems)
        {
            if (item.name == itemName) { 
                inventoryItems.Remove(item);
                return true; 
            }
        }
        return false;
    }

}
