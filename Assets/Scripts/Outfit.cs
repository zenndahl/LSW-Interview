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

    public static int GetCost(OutfitType _outfitType)
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

    public static Sprite GetSprite(OutfitType _outfitType)
    {
        switch (_outfitType)
        {
            default:
            //call the correct sprite to show in the shop
            case OutfitType.WhiteShirt: return GameAssets.i.WhiteShirtSprite; 
            case OutfitType.RedShirt: return GameAssets.i.RedShirtSprite; 
            case OutfitType.YellowShirt: return GameAssets.i.YellowShirtSprite; 
            case OutfitType.OrangeShirt: return GameAssets.i.OrangeShirtSprite;
        }
    }
}
