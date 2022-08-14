using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float force;
    

    public bool losep = false;
    public GameObject losePanel;

    public GameManager gm;

    public bool isScorePoint= false;

    public AudioSource audioSource;
    public AudioClip jump_music;



    void Start()
    {
        Time.timeScale = 1;
        losePanel.SetActive(false);
    }

    void LateUpdate()
    {

        
        
        
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0) && losep==false)
        {
            rb.AddForce(Vector3.up * (force - rb.velocity.y), ForceMode.Impulse);
            audioSource.PlayOneShot(jump_music);
        }

        if(losep == true)
        {
            
            Time.timeScale = 0;
            //Debug.Log("true");
            losePanel.SetActive(true);
        }
        
        
    }



    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("tube"))
        {
            Debug.Log("tube");
            losep = true;
        }

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="scorePoint")
        {
            isScorePoint = true;
            gm.score += 100;
            Debug.Log("+100");
        }
        else
            isScorePoint = false;
    }




}
