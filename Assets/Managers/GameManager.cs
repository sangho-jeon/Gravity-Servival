using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public float PlayerHP = 1.0f;
     public Player mainplayer;
     
     public static GameManager Instance{
        get{
            return instance;
        }
    }
    private static GameManager instance;
    // Start is called before the first frame update
    void Awake(){
        if(instance){
            DestroyImmediate(gameObject);
            return; 
        }
        else{
            instance = this;
        }
        DontDestroyOnLoad(gameObject);

       
    }
    void Start(){
    }
   
}
