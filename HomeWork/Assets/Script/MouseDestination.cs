using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDestination : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 targetPosition;
    private bool isMoving = false;

    void Start()
    {
        targetPosition = transform.position;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            targetPosition = mousePos;
            isMoving = true;
        }

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.01f)
            {
                isMoving = false;
            }
        }
    }
}
