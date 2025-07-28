using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position; // Khởi tạo ban đầu
    }

    // Update is called once per frame
    void Update()
    {
        MouseClickToMove();
        MoveToTarget();
    }
    private void MouseClickToMove()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0f;
            target=mousePos;
        }    
    }    
    private void MoveToTarget()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed*Time.deltaTime);
    }    

}
