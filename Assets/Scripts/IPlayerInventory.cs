using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerInventory
{
    public void CollectFlower(int flowerType);
    public void AddGold(int goldAmount);
    public void EquipItem(Item.ItemType itemToEquip);
}
