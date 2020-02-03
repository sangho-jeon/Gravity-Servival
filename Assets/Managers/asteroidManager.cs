using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroidManager : MonoBehaviour
{

    
    
    
    private int asteroidnum;
    // Start is called before the first frame update
    void Start()
    {
        asteroidnum = ObjectPoolManager.Instance.AsteroidPool.alloccount;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=1;i<10;i++){
            if(GameManager.Instance.mainplayer.playerScore==1500*i){
            StartCoroutine(Deploy());
            break;
            }
        }
    }
    
    IEnumerator Deploy(){
        Debug.Log("deployed!");
        for(int i=0;i<asteroidnum;i++){
        ObjectPoolManager.Instance.AsteroidPool.PopObj();
        yield return new WaitForSeconds(1.5f);
        }
    }
    


}
