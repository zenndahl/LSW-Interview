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
    public Sprite NoAccessorySprite;
    public Sprite FarmerHat;
    public Sprite RedCirclet;
    public Sprite YellowCirclet;
    public Sprite OrangeCirclet;

    [Header("Audio Assets")]
    public AudioClip earnGold;
    public AudioClip buyItem;
    public AudioClip failedBuy;
    public AudioClip equipItem;

}
