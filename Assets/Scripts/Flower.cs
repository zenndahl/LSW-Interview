using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour
{
    [SerializeField] private int goldValue;
    [SerializeField] private int flowerType;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IPlayerInventory player = other.gameObject.GetComponent<IPlayerInventory>();
            player.AddGold(goldValue);
            player.CollectFlower(flowerType);
            //play sound
            transform.parent.GetComponent<FlowerSpawner>().SetFlower(false);
            Destroy(gameObject);
        }
    }
}
