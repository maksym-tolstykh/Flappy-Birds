using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject menuCanvas;
    public GameObject loadCanvas;

    void Start()
    {
        menuCanvas.SetActive(true);
        loadCanvas.SetActive(false);

    }

    public void StartGame()
    {
        menuCanvas.SetActive(false);
        loadCanvas.SetActive(true);
    }

    
    public void exitGame()
    {
        Application.Quit();
        
    }
}
