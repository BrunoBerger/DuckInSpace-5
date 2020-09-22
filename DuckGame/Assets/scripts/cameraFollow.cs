using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(0, 0.5f)]public float followSpeed;

    private Vector3 desiredPosition;
    private Vector3 smoothedPosition;

    private void FixedUpdate()
    {
        desiredPosition = target.position + offset;
        smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, followSpeed);
        transform.position = smoothedPosition;
    }
}
