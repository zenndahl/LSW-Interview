using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject interactionTooltip;
    [SerializeField] private GameObject inventoryUI;
    private bool canInteract = false;

    void Update()
    {
        if (!inventoryUI.activeSelf && Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            inventoryUI.SetActive(true);
        }

        if (inventoryUI.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            inventoryUI.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = true;
            interactionTooltip.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            canInteract = false;
            interactionTooltip.SetActive(false);
        }
    }

}
