using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CircleSpawnByClick : MonoBehaviour
{
    [SerializeField] private GameObject CirclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 spawPos= Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spawPos.z = 0f;
            //Instantiate(CirclePrefab, spawPos, Quaternion.identity);
            GameObject gameObject = Instantiate(CirclePrefab, spawPos, Quaternion.identity);
            Destroy(gameObject, 3f);
      
        }
    }

}
