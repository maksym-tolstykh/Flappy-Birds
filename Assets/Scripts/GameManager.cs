using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text scoretxt;
    public Text maxScoretxt;
    public Text scrtxtscore;  
    public int score;
    public int maxScore;
    public PlayerController pc;

    public GameObject obstacle;
    public GameObject bg_Lod;
    public GameObject grass_Lod;

    private void Awake()
    {
         obstacle = Resources.Load<GameObject>("obstacle");
         bg_Lod = Resources.Load<GameObject>("Background_Lod");
        grass_Lod = Resources.Load<GameObject>("Graund_Plane");
        

    }

    private void Start()
    {
        Application.targetFrameRate = 60;
        maxScore = PlayerPrefs.GetInt("MAXScore");
        StartCoroutine(GenerateObstacles());
        //StartCoroutine(Generatebg_lod());
    }

    public void LateUpdate()
    {
       if(pc.isScorePoint)
        {
            
            scrtxtscore.text = "Рахунок: " + score;
            scoretxt.text = "Рахунок: " + score;
            maxScore = PlayerPrefs.GetInt("MAXScore");
            maxScoretxt.text = "Рекорд: " + maxScore;

        }

        if (maxScore < score && pc.losep == true)
        {
            maxScore = score;
            PlayerPrefs.SetInt("MAXScore", maxScore);
        }
        else
        {
            maxScore = PlayerPrefs.GetInt("MAXScore");
            maxScoretxt.text = "Рекорд: " + maxScore;
        }




    }

    public void restartGame()
    {  
        SceneManager.LoadScene(1);
    }

    public void exitGame()
    {
        Application.Quit();

    }

    public void DeleteSave()
    {
        PlayerPrefs.DeleteKey("MAXScore");
    }

   
    IEnumerator GenerateObstacles()
    {
        Vector2 position;
        while (true)
        {

            position = transform.position;
            // відстань від Flappy до obstacle
            position.x += 35.0F;
            
            Instantiate(obstacle, position, Quaternion.identity);

            yield return new WaitForSeconds(1.0F);

        }
    }
}
