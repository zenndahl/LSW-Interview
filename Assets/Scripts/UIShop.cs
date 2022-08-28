using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private IShopCustomer _shopCustomer;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("ShopItemTemplate");
        //shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        CreateItemButton(Item.ItemType.YellowShirt, Item.GetSprite(Item.ItemType.YellowShirt), "Yellow Shirt", Item.GetCost(Item.ItemType.YellowShirt), 0);
        CreateItemButton(Item.ItemType.OrangeShirt, Item.GetSprite(Item.ItemType.OrangeShirt), "Orange Shirt", Item.GetCost(Item.ItemType.OrangeShirt), 1);
        CreateItemButton(Item.ItemType.RedShirt, Item.GetSprite(Item.ItemType.RedShirt), "Red Shirt", Item.GetCost(Item.ItemType.RedShirt), 2);
        CreateItemButton(Item.ItemType.YellowFlowerCirclet, Item.GetSprite(Item.ItemType.YellowFlowerCirclet), "Yellow Flower Circlet", Item.GetCost(Item.ItemType.YellowFlowerCirclet), 3);
        CreateItemButton(Item.ItemType.OrangeFlowerCirclet, Item.GetSprite(Item.ItemType.OrangeFlowerCirclet), "Orange Flower Circlet", Item.GetCost(Item.ItemType.OrangeFlowerCirclet), 4);
        CreateItemButton(Item.ItemType.RedFlowerCirclet, Item.GetSprite(Item.ItemType.RedFlowerCirclet), "Red Flower Circlet", Item.GetCost(Item.ItemType.RedFlowerCirclet), 5);
        CreateItemButton(Item.ItemType.FarmerHat, Item.GetSprite(Item.ItemType.FarmerHat), "Farmer Hat", Item.GetCost(Item.ItemType.FarmerHat), 6);
        shopItemTemplate.gameObject.SetActive(false);

        Hide();
    }

    private void CreateItemButton(Item.ItemType itemType, Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        //RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        //float shopItemHeight = 30f;
        //shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("ItemCost").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button>().onClick.AddListener(delegate { TryBuyItem(itemType); });
        
    }

    public void TryBuyItem(Item.ItemType itemType)
    {
        _shopCustomer.BoughtItem(itemType);
    }

    public void Show(IShopCustomer shopCustomer)
    {
        _shopCustomer = shopCustomer;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
    
}
