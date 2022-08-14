using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleHelper : MonoBehaviour
{

    public float speed;
    public float destroy;
    public float y_pos_min = -1.5f, y_pos_max = 2.5f;
    void Start()
    {
        Vector2 position = transform.position;

        position.y = Random.Range(y_pos_min, y_pos_max);

        transform.position = position;

        Destroy(gameObject, destroy);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.position - transform.right, speed * Time.deltaTime);
    }
}
