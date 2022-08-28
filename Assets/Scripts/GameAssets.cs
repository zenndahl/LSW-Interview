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

    [Header("Only Shirts Animations")]
    public Animation RedShirtAnim;
    public Animation OrangeShirtAnim;
    public Animation YellowShirtAnim;

    [Header("Red Shirts and Circlets Animations")]
    public Animation DWhiteShirtAnim;
    public Animation DWhiteShirtRedFlowerAnim;
    public Animation DRedShirtRedFlowerAnim;
    public Animation DOrangeShirtRedFlowerAnim;
    public Animation DYellowShirtRedFlowerAnim;

    public Animation UWhiteShirtAnim;
    public Animation UWhiteShirtRedFlowerAnim;
    public Animation URedShirtRedFlowerAnim;
    public Animation UOrangeShirtRedFlowerAnim;
    public Animation UYellowShirtRedFlowerAnim;

    public Animation LWhiteShirtAnim;
    public Animation LWhiteShirtRedFlowerAnim;
    public Animation LRedShirtRedFlowerAnim;
    public Animation LOrangeShirtRedFlowerAnim;
    public Animation LYellowShirtRedFlowerAnim;

    public Animation RWhiteShirtAnim;
    public Animation RWhiteShirtRedFlowerAnim;
    public Animation RRedShirtRedFlowerAnim;
    public Animation ROrangeShirtRedFlowerAnim;
    public Animation RYellowShirtRedFlowerAnim;

    [Header("Orange Shirts and Circlets Animations")]
    public Animation DWhiteShirtOrangeFlowerAnim;
    public Animation DRedShirtOrangeFlowerAnim;
    public Animation DOrangeShirtOrangeFlowerAnim;
    public Animation DYellowShirtOrangeFlowerAnim;

    public Animation UWhiteShirtOrangeFlowerAnim;
    public Animation URedShirtOrangeFlowerAnim;
    public Animation UOrangeShirtOrangeFlowerAnim;
    public Animation UYellowShirtOrangeFlowerAnim;

    public Animation LWhiteShirtOrangeFlowerAnim;
    public Animation LRedShirtOrangeFlowerAnim;
    public Animation LOrangeShirtOrangeFlowerAnim;
    public Animation LYellowShirtOrangeFlowerAnim;

    public Animation RWhiteShirtOrangeFlowerAnim;
    public Animation RRedShirtOrangeFlowerAnim;
    public Animation ROrangeShirtOrangeFlowerAnim;
    public Animation RYellowShirtOrangeFlowerAnim;

    [Header("Orange Shirts and Circlets Animations")]
    public Animation DWhiteShirtYellowFlowerAnim;
    public Animation DRedShirtYellowFlowerAnim;
    public Animation DOrangeShirtYellowFlowerAnim;
    public Animation DYellowShirtYellowFlowerAnim;

    public Animation UWhiteShirtYellowFlowerAnim;
    public Animation URedShirtYellowFlowerAnim;
    public Animation UOrangeShirtYellowFlowerAnim;
    public Animation UYellowShirtYellowFlowerAnim;

    public Animation LWhiteShirtYellowFlowerAnim;
    public Animation LRedShirtYellowFlowerAnim;
    public Animation LOrangeShirtYellowFlowerAnim;
    public Animation LYellowShirtYellowFlowerAnim;

    public Animation RWhiteShirtYellowFlowerAnim;
    public Animation RRedShirtYellowFlowerAnim;
    public Animation ROrangeShirtYellowFlowerAnim;
    public Animation RYellowShirtYellowFlowerAnim;

    [Header("Shirts and Farmer Hat Animations")]
    public Animation DWhiteShirtHatAnim;
    public Animation DRedShirtHatAnim;
    public Animation DOrangeShirtHatAnim;
    public Animation DYellowShirtHatAnim;

    public Animation UWhiteShirtHatAnim;
    public Animation URedShirtHatAnim;
    public Animation UOrangeShirtHatAnim;
    public Animation UYellowShirtHatAnim;

    public Animation LWhiteShirtHatAnim;
    public Animation LRedShirtHatAnim;
    public Animation LOrangeShirtHatAnim;
    public Animation LYellowShirtHatAnim;

    public Animation RWhiteShirtHatAnim;
    public Animation RRedShirtHatAnim;
    public Animation ROrangeShirtHatAnim;
    public Animation RYellowShirtHatAnim;

}
