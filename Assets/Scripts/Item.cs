using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        WhiteShirt,
        RedShirt,
        YellowShirt,
        OrangeShirt,
        FlowersCirclet,
        RedFlowerCirclet,
        YellowFlowerCirclet,
        OrangeFlowerCirclet,
        FarmerHat,
    }

    public static int GetCost(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.WhiteShirt: return 0;
            case ItemType.RedShirt: return 50;
            case ItemType.YellowShirt: return 20;
            case ItemType.OrangeShirt: return 30;
            case ItemType.RedFlowerCirclet: return 50;
            case ItemType.FlowersCirclet: return 45;
            case ItemType.YellowFlowerCirclet: return 20;
            case ItemType.OrangeFlowerCirclet: return 30;
            case ItemType.FarmerHat: return 40;
        }
    }

    public static Sprite GetSprite(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.WhiteShirt: return GameAssets.i.WhiteShirtSprite;
            case ItemType.RedShirt: return GameAssets.i.RedShirtSprite;
            case ItemType.YellowShirt: return GameAssets.i.YellowShirtSprite;
            case ItemType.OrangeShirt: return GameAssets.i.OrangeShirtSprite;
            case ItemType.RedFlowerCirclet: return GameAssets.i.RedCirclet;
            case ItemType.YellowFlowerCirclet: return GameAssets.i.YellowCirclet;
            case ItemType.OrangeFlowerCirclet: return GameAssets.i.OrangeCirclet;
            case ItemType.FarmerHat: return GameAssets.i.FarmerHat;
        }
    }
}
