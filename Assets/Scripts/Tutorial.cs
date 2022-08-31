using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    [SerializeField] private float lifeTime = 3f;

    // Update is called once per frame
    void Update()
    {
        if (lifeTime < 0.1) Destroy(gameObject);
        else lifeTime -= Time.deltaTime;
    }
}
