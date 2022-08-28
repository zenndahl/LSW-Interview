using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform target = null;
    [SerializeField] private float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    private void FixedUpdate()
    {
        Vector3 goalPos = target.position;
        goalPos.y = transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, goalPos, ref velocity, smoothTime);

    }
}
