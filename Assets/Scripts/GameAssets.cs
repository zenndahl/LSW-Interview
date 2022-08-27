using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i
    {
        get {
            if (_i == null)
            {
                _i = (Instantiate(Resources.Load("Prefabs/GameAssets")) as GameObject).GetComponent<GameAssets>();
            } 
            return _i; 
        }
    }

    [Header("Shirts Assets")]
    public Sprite WhiteShirtSprite;
    public Sprite RedShirtSprite;
    public Sprite OrangeShirtSprite;
    public Sprite YellowShirtSprite;

    [Header("Accessory Assets")]
    public Sprite FarmerHat;
    public Sprite RedCirclet;
    public Sprite YellowCirclet;
    public Sprite OrangeCirclet;

    [Header("Only Shirts Spritesheets")]
    public Sprite RedShirtSpritesheet;
    public Sprite OrangeShirtSpritesheet;
    public Sprite YellowShirtSpritesheet;

    [Header("Shirts and Hats Spritesheets")]
    //red flowers
    public Sprite WhiteShirtRedFlowerSpritesheet;
    public Sprite RedShirtRedFlowerSpritesheet;
    public Sprite OrangeShirtRedFlowerSpritesheet;
    public Sprite YellowShirtRedFlowerSpritesheet;

    //orange flowers
    public Sprite WhiteShirtOrangeFlowerSpritesheet;
    public Sprite RedShirtOrangeFlowerSpritesheet;
    public Sprite OrangeShirtOrangeFlowerSpritesheet;
    public Sprite YellowShirtOrangeFlowerSpritesheet;

    //yellow flowers
    public Sprite WhiteShirtYellowFlowerSpritesheet;
    public Sprite RedShirtYellowFlowerSpritesheet;
    public Sprite OrangeShirtYellowFlowerSpritesheet;
    public Sprite YellowShirtYellowFlowerSpritesheet;
    
    //hat
    public Sprite RedShirtHatSpritesheet;
    public Sprite OrangeShirtHatSpritesheet;
    public Sprite YellowShirtHatSpritesheet;

}
