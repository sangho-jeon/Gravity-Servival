using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pauseUI : MonoBehaviour
{
    public GameObject PauseUI;
    public bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(paused == true){
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
        }
        if(!paused){
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }

    }
    public void OnSetting(){
        paused = true;
    }
    public void BackToGame(){
        paused = false;
    }
    public void Home(){
        SceneManager.LoadScene("startScene");

    }
    public void Exit(){
        Application.Quit();
    }
}
