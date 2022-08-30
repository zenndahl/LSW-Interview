using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //THIS SCRIPT ITS NOT WORKING FOR REASONS UNKNOWN TO MY PERSON


    private List<Item.ItemType> _items = new List<Item.ItemType>();

    private List<Item.ItemType> equipedItems = new List<Item.ItemType>(2);

    public void AddItemToInventory(Item.ItemType itemToAdd)
    {
        print(itemToAdd);
        _items.Add(itemToAdd); //for some reason the object is lost here
    }

    public void EquipItem(Item.ItemType itemToEquip)
    {
        foreach(Item.ItemType item in equipedItems)
        {
            //the player can only have 2 items, 1 outfit (shirt) and 1 accessory (headpiece)
            if(Item.GetLabel(item) == Item.GetLabel(itemToEquip))
            {
                equipedItems.Remove(item);
                equipedItems.Add(itemToEquip);
            }
            else if(equipedItems.Count < 2)
            {
                equipedItems.Add(itemToEquip);
            }
        }
    }

    public List<Item.ItemType> GetInventoryItems()
    {
        return _items;
    }

    public List<Item.ItemType> GetEquipedItems()
    {
        return equipedItems;
    }
}
