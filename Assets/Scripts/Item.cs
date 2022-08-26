using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        SimpleFertilizer,
        ManureFertilizer,
        CompostFertilizer,
        SimpleFishingRod,
        ReinforcedFishingRod,
        ProfessionalFishingRod,
        SimpleBasket,
        LargeBasket,
    }

    public static int GetItemCost(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.SimpleFertilizer:         return 10;
            case ItemType.ManureFertilizer:         return 20;
            case ItemType.CompostFertilizer:        return 30;
            case ItemType.SimpleFishingRod:         return 20;
            case ItemType.ReinforcedFishingRod:     return 40;
            case ItemType.ProfessionalFishingRod:   return 60;
            case ItemType.SimpleBasket:             return 25;
            case ItemType.LargeBasket:              return 50;
        }
    }

    public static Sprite GetItemSprite(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.SimpleFertilizer: return null; //call the correct sprite to show in the shop
        }
    }
}
