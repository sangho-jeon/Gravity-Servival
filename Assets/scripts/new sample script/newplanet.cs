using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newplanet : PoolableObject
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector2 Dis;
        Dis = GameManager.Instance.mainplayer.transform.position-gameObject.transform.position;
        if(Mathf.Abs(Dis.x)>20||Mathf.Abs(Dis.y)>28){
            this.push();

            Respawn();
        }
       
    }
  
    


    public void  Respawn(){
         
            Vector2 bigoneposition;
            int Case = Random.Range(1,4);
            GameObject tobj = Pool.PopObj();
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            //GameObject tobj = ObjectPoolManager.Instance.EnemyPool.PopObj();
            switch(Case)
            {
                case 1:
                    bigoneposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,20.0f);
                    bigoneposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,-5.0f);
                    tobj.transform.position = bigoneposition;
                    break;
                case 2:
                    bigoneposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,20.0f);
                    bigoneposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(5.0f,28.0f);
                    tobj.transform.position = bigoneposition;
                    break;
                case 3:
                    bigoneposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,-3.0f);
                    bigoneposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,28.0f);
                    tobj.transform.position = bigoneposition;
                    break;
                case 4:
                    bigoneposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(3.0f,20.0f);
                    bigoneposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,28.0f);
                    tobj.transform.position = bigoneposition;
                    break; 
                
            }
 
        }
    
}
