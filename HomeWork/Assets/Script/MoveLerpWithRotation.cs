using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLerpWithRotation : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public Transform pointC;
    public float speed = 1f;
    public float rotationSpeed = 180f; // độ/giây

    private float t = 0f;
    private bool movingToB = true;
    private bool movingToC = true;
    private bool movingToA = true;

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
                movingToC = true;
                movingToA = false;
            }
        }
        if (movingToC)
        {
            transform.position = Vector3.Lerp(pointB.position, pointC.position, t);
            if (t >= 1f)
            {
                t = 0f;
                movingToC = false;
                movingToA = true;
                movingToB = false;
            }
        }
        if (movingToA)
        {
            transform.position = Vector3.Lerp(pointC.position, pointA.position, t);
            if (t >= 1f)
            {
                t = 0f;
                movingToC = false;
                movingToB = true;
                movingToA = false;
            }
        }


        // Xoay theo chiều kim đồng hồ (âm quanh Z trong hệ tọa độ 2D)
        transform.Rotate(0f, 0f, -rotationSpeed * Time.deltaTime);
    }
}
