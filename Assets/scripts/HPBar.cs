using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HPBar : MonoBehaviour
{
    private Image bar; 
    
    float hp;
    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        hp = GameManager.Instance.mainplayer.PlayerHp;
        bar.fillAmount = hp;
    }
  

  
}
