using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopkeeperInteraction : NpcInteraction
{
    [SerializeField] private GameObject shop;
    private IShopCustomer shopCustomer;
    private bool canOpenShop;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            if(!dialogText.activeSelf)
            {
                dialogText.SetActive(true);
            }

            //the shop verification prevents the dialog to open if the player press E and the shop is open
            if (dialogText.activeSelf && !shop.activeSelf)
            {
                dialogText.SetActive(false);
                if (shopCustomer != null) OpenShop();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape) && canInteract)
        {
            if(dialogText.activeSelf) dialogText.SetActive(false);
            if (shop.activeSelf) CloseShop();
        }
    }

    private void OpenShop()
    {
        if(shopCustomer != null)
        {
            shop.GetComponent<UIShop>().Show(shopCustomer);
            Cursor.visible = true;
        }
    }

    private void CloseShop()
    {
        if (shopCustomer != null)
        {
            shop.GetComponent<UIShop>().Hide();
            Cursor.visible = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionTooltip.SetActive(true);
            canInteract = true;
            shopCustomer = other.GetComponent<IShopCustomer>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionTooltip.SetActive(false);
            canInteract = false;

            if(dialogText.activeSelf) dialogText.SetActive(false);

            if (shop.activeSelf)
            {
                shopCustomer = other.GetComponent<IShopCustomer>();
                if(shopCustomer != null) CloseShop();    
            }
        }
    }
}
