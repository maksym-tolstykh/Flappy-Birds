using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject frame1;
    public GameObject frame2;
    public GameObject frame3;
    

    public void Start()
    {
        StartCoroutine(Flappy_anim());
    }

    IEnumerator Flappy_anim()
    {
        while(true){
            frame1.SetActive(true);
            frame2.SetActive(false);
            frame3.SetActive(false);
            yield return new WaitForSecondsRealtime(0.08f);
            frame1.SetActive(false);
            frame2.SetActive(true);
            frame3.SetActive(false);
            yield return new WaitForSecondsRealtime(0.08f);
            frame1.SetActive(false);
            frame2.SetActive(false);
            frame3.SetActive(true);
            yield return new WaitForSecondsRealtime(0.08f);
        }
    }
}
