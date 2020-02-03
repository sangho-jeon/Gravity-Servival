using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : Planet
{
    public float rotatespeed = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
     void OnTriggerEnter2D(Collider2D player){
        if(player.gameObject.CompareTag("player")){
            this.push();
            GameManager.Instance.mainplayer.PlayerHp += 0.5f; 
        }

        
    }
}
