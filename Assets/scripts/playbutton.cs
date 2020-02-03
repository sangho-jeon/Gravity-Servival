using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playbutton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(580, 960, FullScreenMode.Windowed);
        Screen.fullScreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickEnter(){
        
            SceneManager.LoadScene("gameScene");
        
        

    }
}
