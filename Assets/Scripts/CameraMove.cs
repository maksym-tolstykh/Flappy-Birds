using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject flappy;
    public new Camera camera;
    public Vector3 offset;
    public float smooth = 5.0f;

    private void Start()
    {
        
        offset = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z) - flappy.transform.position;
    }

    void LateUpdate()
    {
        
        camera.transform.position =Vector3.Lerp(flappy.transform.position+ offset, flappy.transform.position+offset,Time.deltaTime* smooth);
    }
}
