using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLodTriger : MonoBehaviour
{
    bool isD= false;
    private void LateUpdate()
    {
        if(isD == true)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bird")
        {
            isD = true;
            Destroy(gameObject);
            Debug.Log("Destroy");
        }
    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Bird")
        {
            
            Destroy(gameObject);
            Debug.Log("Destroy");
        }
    }
}
