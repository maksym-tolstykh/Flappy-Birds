using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour
{
    public GameObject settings_panel;
    public GameObject bttn_music_off;
    public GameObject bttn_music_on;

    
    

    public AudioSource musicAudio;
    
    [SerializeField]
    int offORonMusic = 1;

    private void Start()
    {
        
        LoadSettings();
   
    }


    private void Update()
    {

        if (offORonMusic == 1)
        {
            musicAudio.Play();
           
        }
        else if (offORonMusic == 0)
        {
            musicAudio.Stop();
            
        }
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("offORonMusic", offORonMusic);
        Debug.Log("Data save");
        
    }
    void LoadSettings()
    {
        if (PlayerPrefs.HasKey("offORonMusic"))
        {
            offORonMusic = PlayerPrefs.GetInt("offORonMusic");
            Debug.Log("Data loaded");
        }
    }

    #region menu
    public void startMenuSettings()
    {
        settings_panel.SetActive(true);
        
    }

    public void closeMenuSettings()
    {
        SaveSettings();
        settings_panel.SetActive(false);
    }

    #endregion
    #region Music Play or Stop
    public void musicOff()
    {
        offORonMusic = 0;
        SaveSettings(); 
    }

    public void musicOn()
    {
        offORonMusic = 1;
        SaveSettings();
    }
    #endregion

    public void DeleteSettings()
    {
        offORonMusic = 1;
        PlayerPrefs.DeleteKey("offORonMusic");
    }
}
