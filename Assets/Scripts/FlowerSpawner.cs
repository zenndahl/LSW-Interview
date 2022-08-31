using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawner : MonoBehaviour
{
    private float spawnTime = 0f;
    private float spawnCountdown;
    private GameObject flowerPrefab;
    private bool hasFlower = false;

    void Start()
    {
        float r = Random.Range(0, 2.5f);
        GetFlowerPrefab(r);
    }

    private void GetFlowerPrefab(float r)
    {
        if (r >= 0 && r < 1) flowerPrefab = (GameObject)Resources.Load("Prefabs/YellowFlower");
        if (r >= 1 && r < 2) flowerPrefab = (GameObject)Resources.Load("Prefabs/OrangeFlower");
        if (r >= 2) flowerPrefab = (GameObject)Resources.Load("Prefabs/RedFlower");
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasFlower)
        {
            if (spawnCountdown < 0.1f)
            {
                Spawn();
                SetTimer();

            }
            else spawnCountdown -= Time.deltaTime;
        }
    }

    private void SetTimer()
    {
        spawnTime = Random.Range(25, 40);
        spawnCountdown = spawnTime;
    }

    private void Spawn()
    {
        GameObject flower = Instantiate(flowerPrefab);
        flower.transform.position = transform.position;
        flower.transform.parent = transform;
        hasFlower = true;
    }

    public void SetFlower(bool status)
    {
        hasFlower = status;
    }
}
