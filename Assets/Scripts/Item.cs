using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        NoAccessory,
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

    public static string GetName(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.WhiteShirt: return "White Shirt";
            case ItemType.RedShirt: return "Red Shirt";
            case ItemType.YellowShirt: return "Yellow Shirt";
            case ItemType.OrangeShirt: return "Orange Shirt";
            case ItemType.FlowersCirclet: return "Flowers Circlet";
            case ItemType.RedFlowerCirclet: return "Red Flowers Circlet";
            case ItemType.YellowFlowerCirclet: return "Yellow Flowers Circlet";
            case ItemType.OrangeFlowerCirclet: return "Orange Flowers Circlet";
            case ItemType.FarmerHat: return "Farmer Hat";
            case ItemType.NoAccessory: return "No Accessory";
        }
    }

    public static string GetLabel(ItemType _itemType)
    {
        switch (_itemType)
        {
            default:
            case ItemType.WhiteShirt: return "Outfit";
            case ItemType.RedShirt: return "Outfit";
            case ItemType.YellowShirt: return "Outfit";
            case ItemType.OrangeShirt: return "Outfit";
            case ItemType.FlowersCirclet: return "Accessory";
            case ItemType.RedFlowerCirclet: return "Accessory";
            case ItemType.YellowFlowerCirclet: return "Accessory";
            case ItemType.OrangeFlowerCirclet: return "Accessory";
            case ItemType.FarmerHat: return "Accessory";
            case ItemType.NoAccessory: return "Accessory";
        }
    }
}
