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
            GameObject.Find("AudioManager").GetComponent<AudioSource>().clip = GameAssets.i.earnGold;
            GameObject.Find("AudioManager").GetComponent<AudioSource>().Play();
            transform.parent.GetComponent<FlowerSpawner>().SetFlower(false);
            Destroy(gameObject);
        }
    }
}
