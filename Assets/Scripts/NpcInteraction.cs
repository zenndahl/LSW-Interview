using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NpcInteraction : MonoBehaviour
{
    public GameObject interactionTooltip;
    public GameObject dialogText;
    protected bool canInteract = false;

    private void Update()
    {
        if(!dialogText.activeSelf && Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            dialogText.SetActive(true);
        }

        if(dialogText.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogText.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            interactionTooltip.SetActive(true);
            canInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionTooltip.SetActive(false);
            canInteract = false;
            if (dialogText.activeSelf)
            {
                dialogText.SetActive(false);
            }
        }
    }
}
