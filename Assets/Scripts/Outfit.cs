using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Outfit
{
    public enum OutfitType
    {
        WhiteShirt,
        RedShirt,
        YellowShirt,
        OrangeShirt,
        OrangeRedStripedShirt,
        OrangeYellowStripedShirt,
        RedYellowStripedShirt,
    }

    public static int GetOutfitCost(OutfitType _outfitType)
    {
        switch (_outfitType)
        {
            default:
            case OutfitType.WhiteShirt:                return 0;
            case OutfitType.RedShirt:                  return 50;
            case OutfitType.YellowShirt:               return 20;
            case OutfitType.OrangeShirt:               return 30;
            case OutfitType.OrangeRedStripedShirt:     return 40;
            case OutfitType.OrangeYellowStripedShirt:  return 25;
            case OutfitType.RedYellowStripedShirt:     return 35;
        }
    }

    public static Sprite GetOufitSprite(OutfitType _outfitType)
    {
        switch (_outfitType)
        {
            default:
            case OutfitType.WhiteShirt: return null; //call the correct sprite to show in the shop
        }
    }
}
