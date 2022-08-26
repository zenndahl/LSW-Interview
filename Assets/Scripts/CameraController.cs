using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject target = null;
    [SerializeField] private float smoothTine = 0;
    [SerializeField] private Vector3 offset = new Vector3(0, 0, -10);

    void Start()
    {
        target = GameObject.Find("Player");
    }

    void Update()
    {
        transform.LookAt(target.transform);
    }

    private void LateUpdate()
    {
        //Vector3 camPos = new (target.transform.position.x, target.transform.position.x, -10);
        transform.position = Vector3.Lerp(transform.position, target.transform.position + offset, smoothTine);
        
    }
}
