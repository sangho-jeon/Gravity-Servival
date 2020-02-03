using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ReplayButton : MonoBehaviour
{
    public Text txtscore;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(580, 960, FullScreenMode.Windowed);
        Screen.fullScreen = false;
        int score = GameManager.Instance.mainplayer.playerScore;
        txtscore.text =  string.Format("Score: {0}", score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Replay(){
        SceneManager.LoadScene("startScene");
    }
    public void ExitGame(){
        Application.Quit();
    }
}
