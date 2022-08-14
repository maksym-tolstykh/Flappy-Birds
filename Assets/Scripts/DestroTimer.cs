using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroTimer : MonoBehaviour
{

    public float time = 60f;  
    void LateUpdate()
    {

        time -= Time.deltaTime;
        if(time < 0)
        {
            Destroy(gameObject);
        }
    }
}
