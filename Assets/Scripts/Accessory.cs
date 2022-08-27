using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessory
{
    public enum AccessoryType
    {
        NoAccessory,
        FlowersCirclet,
        RedFlowerCirclet,
        YellowFlowerCirclet,
        OrangeFlowerCirclet,
        FarmerHat,
        RedCap,
        YellowCap,
        OrangeCap,
        Sunglasses,
    }

    public static int GetCost(AccessoryType _accessoryType)
    {
        switch (_accessoryType)
        {
            default:
            case AccessoryType.NoAccessory:             return 0;
            case AccessoryType.RedFlowerCirclet:        return 50;
            case AccessoryType.FlowersCirclet:          return 45;
            case AccessoryType.YellowFlowerCirclet:     return 20;
            case AccessoryType.OrangeFlowerCirclet:     return 30;
            case AccessoryType.FarmerHat:               return 40;
            case AccessoryType.RedCap:                  return 25;
            case AccessoryType.YellowCap:               return 35;
            case AccessoryType.OrangeCap:               return 35;
            case AccessoryType.Sunglasses:              return 35;
        }
    }

    public static string GetName(AccessoryType _accessoryType)
    {
        switch (_accessoryType)
        {
            default:
            case AccessoryType.NoAccessory: return "None";
            case AccessoryType.FlowersCirclet: return "Flowers Circlet";
            case AccessoryType.RedFlowerCirclet: return "Red Flower Circlet";
            case AccessoryType.YellowFlowerCirclet: return "Yellow Flower Circlet";
            case AccessoryType.OrangeFlowerCirclet: return "Orange Flower Circlet";
            case AccessoryType.FarmerHat: return "Farmer Hat";
            //case AccessoryType.RedCap: return "Red Cap";
            //case AccessoryType.YellowCap: return "Yellow Cap";
            //case AccessoryType.OrangeCap: return "Orange Cap";
            //case AccessoryType.Sunglasses: return "Sunglasses;
        }
    }

    public static Sprite GetSprite(AccessoryType _accessoryType)
    {
        switch (_accessoryType)
        {
            default:
            //call the correct sprite to show in the shop
            case AccessoryType.RedFlowerCirclet: return GameAssets.i.RedCirclet;
            case AccessoryType.YellowFlowerCirclet: return GameAssets.i.YellowCirclet;
            case AccessoryType.OrangeFlowerCirclet: return GameAssets.i.OrangeCirclet;
            case AccessoryType.FarmerHat: return GameAssets.i.FarmerHat;
        }
    }
}
