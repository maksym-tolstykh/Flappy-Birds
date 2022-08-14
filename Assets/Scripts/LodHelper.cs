using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LodHelper : MonoBehaviour
{
    public float speed;
   
    void Start()
    {
        Vector2 position = transform.position;

        transform.position = position;

        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
