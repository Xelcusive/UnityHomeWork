using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAtoB : MonoBehaviour
{
    [SerializeField] private Transform PointA;
    [SerializeField] private Transform PointB;
    [SerializeField] private float speed = 5f;
    private Vector3 target;
    private bool checkPoint=false;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = PointA.position;
        target = PointB.position;
    }

    // Update is called once per frame
    void Update()
    {
        FromAToB();
    }
    private void FromAToB()
    {
        //Di chuyển object
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        //Kiểm tra đích đến
        if (Vector2.Distance(transform.position, target) < 0.01f && transform.position ==PointB.position)
        {
            Invoke(nameof(GoToPointA), 1f); 
        }
        if (Vector2.Distance(transform.position, target) < 0.01f && transform.position == PointA.position)
        {
            Invoke(nameof(GoToPointB), 1f);
        }


    }    
    private void GoToPointA()
    {
      target = PointA.position;
            
    }
    private void GoToPointB()
    {
        target= PointB.position;

    }
}
