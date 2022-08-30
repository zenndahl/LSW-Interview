using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class InventoryUI : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private IPlayerInventory _playerInventory;

    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("InventoryItemTemplate");
    }

    void Start()
    {
        
    }

    private void OnEnable()
    {
        PlayerController player = GameObject.Find("Player").GetComponent<PlayerController>();
        _playerInventory = player.GetComponent<IPlayerInventory>();

        foreach(Item.ItemType item in player.GetInventoryItems())
        {
            CreateItemDisplay(item, Item.GetSprite(item), Item.GetName(item));
        }
    }

    private void CreateItemDisplay(Item.ItemType itemType, Sprite itemSprite, string itemName)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);

        shopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button>().onClick.AddListener(delegate { _playerInventory.EquipItem(itemType); });

    }

    public void Show(IPlayerInventory _playerInventory)
    {
        this._playerInventory = _playerInventory;
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
