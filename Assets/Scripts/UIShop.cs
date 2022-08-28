using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShop : MonoBehaviour
{
    //private Transform container;
    private Transform shopItemTemplate;

    [SerializeField] private Accessory[] _accessories; 
    [SerializeField] private Outfit[] _outfits; 
    [SerializeField] private bool isOutfit; //used to know wich type of item to create in the UI

    private void Awake()
    {
        //container = transform;
        shopItemTemplate = transform.Find("ShopItemTemplate");
        //shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        if (isOutfit)
        {
            //CreateItemButton(Outfit.GetSprite(Outfit.OutfitType.YellowShirt), "Yellow Shirt", Outfit.GetCost(Outfit.OutfitType.YellowShirt), 0);
            CreateItemButton(Accessory.AccessoryType.NoAccessory, Outfit.OutfitType.OrangeShirt, Outfit.GetSprite(Outfit.OutfitType.OrangeShirt), "Orange Shirt", Outfit.GetCost(Outfit.OutfitType.OrangeShirt), 1);
            CreateItemButton(Accessory.AccessoryType.NoAccessory, Outfit.OutfitType.RedShirt, Outfit.GetSprite(Outfit.OutfitType.RedShirt), "Red Shirt", Outfit.GetCost(Outfit.OutfitType.RedShirt), 2);
        }
        else
        {
            //CreateItemButton(Accessory.GetSprite(Accessory.AccessoryType.YellowFlowerCirclet), "Yellow Flower Circlet", Accessory.GetCost(Accessory.AccessoryType.YellowFlowerCirclet), 1);
            CreateItemButton(Accessory.AccessoryType.OrangeFlowerCirclet, Outfit.OutfitType.WhiteShirt, Accessory.GetSprite(Accessory.AccessoryType.OrangeFlowerCirclet), "Orange Flower Circlet", Accessory.GetCost(Accessory.AccessoryType.OrangeFlowerCirclet), 2);
            CreateItemButton(Accessory.AccessoryType.RedFlowerCirclet, Outfit.OutfitType.WhiteShirt, Accessory.GetSprite(Accessory.AccessoryType.RedFlowerCirclet), "Red Flower Circlet", Accessory.GetCost(Accessory.AccessoryType.RedFlowerCirclet), 3);
            CreateItemButton(Accessory.AccessoryType.FarmerHat, Outfit.OutfitType.WhiteShirt, Accessory.GetSprite(Accessory.AccessoryType.FarmerHat), "Farmer Hat", Accessory.GetCost(Accessory.AccessoryType.FarmerHat), 4);
        }
    }

    private void CreateItemButton(Accessory.AccessoryType accessoryType, Outfit.OutfitType outfitType, Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, transform);
        //RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        //float shopItemHeight = 30f;
        //shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("ItemCost").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;

        if (isOutfit)
        {
            shopItemTransform.GetComponent<Button>().onClick.AddListener(delegate { TryBuyOutfit(outfitType); });
        }
        else
        {
            shopItemTransform.GetComponent<Button>().onClick.AddListener(delegate { TryBuyAccessory(accessoryType); });
        }
    }

    public void TryBuyAccessory(Accessory.AccessoryType accessoryType)
    {

    }
    
    public void TryBuyOutfit(Outfit.OutfitType outfitType)
    {

    }
}
