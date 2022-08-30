using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private IPlayerInventory _playerInventory;
    [SerializeField] private GameObject interactionTooltip;
    [SerializeField] private GameObject inventoryUI;
    private bool canInteract = false;

    void Update()
    {
        if (!inventoryUI.activeSelf && Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            OpenInventory();
        }

        if (inventoryUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            CloseInventory();
        }
    }

    private void OpenInventory()
    {
        inventoryUI.SetActive(true);
        inventoryUI.GetComponent<InventoryUI>().Show(_playerInventory);
        Cursor.visible = true;
    }

    private void CloseInventory()
    {
        if (_playerInventory != null)
        {
            inventoryUI.GetComponent<InventoryUI>().Hide();
            inventoryUI.SetActive(false);
            Cursor.visible = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = true;
            interactionTooltip.SetActive(true);
            _playerInventory = other.gameObject.GetComponent<IPlayerInventory>();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = false;
            interactionTooltip.SetActive(false);
            CloseInventory();
        }
    }

}
