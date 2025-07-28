using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerpWithRotation : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 1f;
    public float rotationSpeed = 180f; // độ/giây

    private float t = 0f;
    private bool movingToB = true;

    void Update()
    {
        t += Time.deltaTime * speed;

        if (movingToB)
        {
            transform.position = Vector3.Lerp(pointA.position, pointB.position, t);
            if (t >= 1f)
            {
                t = 0f;
                movingToB = false;
            }
        }
        else
        {
            transform.position = Vector3.Lerp(pointB.position, pointA.position, t);
            if (t >= 1f)
            {
                t = 0f;
                movingToB = true;
            }
        }

        // Xoay theo chiều kim đồng hồ (âm quanh Z trong hệ tọa độ 2D)
        transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
    }
}
