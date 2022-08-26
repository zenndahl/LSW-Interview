using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accessory
{
    public enum AccessoryType
    {
        NoAccessory,
        RedFlowerCirclet,
        YellowFlowerCirclet,
        OrangeFlowerCirclet,
        FarmerHat,
        RedCap,
        YellowCap,
        OrangeCap,
        Sunglasses,
    }

    public static int GetAccessoryCost(AccessoryType _accessoryType)
    {
        switch (_accessoryType)
        {
            default:
            case AccessoryType.NoAccessory:             return 0;
            case AccessoryType.RedFlowerCirclet:        return 50;
            case AccessoryType.YellowFlowerCirclet:     return 20;
            case AccessoryType.OrangeFlowerCirclet:     return 30;
            case AccessoryType.FarmerHat:               return 40;
            case AccessoryType.RedCap:                  return 25;
            case AccessoryType.YellowCap:               return 35;
            case AccessoryType.OrangeCap:               return 35;
            case AccessoryType.Sunglasses:              return 35;
        }
    }

    public static Sprite GetAccessorySprite(AccessoryType _accessoryType)
    {
        switch (_accessoryType)
        {
            default:
            case AccessoryType.RedFlowerCirclet: return null; //call the correct sprite to show in the shop
        }
    }
}
