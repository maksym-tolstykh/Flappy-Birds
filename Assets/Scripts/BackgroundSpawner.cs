using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawner : MonoBehaviour
{
    public float speedLod = 3f;
    public GameObject[] lodPrefabs;
    public List<GameObject> lodList = new List<GameObject>();
    public Transform bird;
    public GameObject startPosLod;

    float xPosLod = 0;
    int lodCount = 0;

    public float speed;

    public void Start()
    {
        

        SpawnBlock();
        StartCoroutine(Generatebg_lod());
        

    }

    private void LateUpdate()
    {
        
    }

   

    void SpawnBlock()
    {
        GameObject Tube = Instantiate(lodPrefabs[Random.Range(0, lodPrefabs.Length)], transform);
        xPosLod += Random.Range(100, 100);
        Tube.transform.position = new Vector3(xPosLod, 0, 0);
        lodList.Add(Tube);


    }

    void DestroyBlock()
    {
        Destroy(lodList[0]);
        lodList.RemoveAt(0);
        lodList.RemoveAt(1);

    }

    IEnumerator Generatebg_lod()
    {
        Vector2 position;
        while (true)
        {
            GameObject Tube = Instantiate(lodPrefabs[Random.Range(0, lodPrefabs.Length)], transform);
            xPosLod += Random.Range(100, 100);
            Tube.transform.position = new Vector3(xPosLod, 0, 0);
            lodList.Add(Tube);
            position.y = 0.0F;
            yield return new WaitForSeconds(5F);

        }
    }
}
