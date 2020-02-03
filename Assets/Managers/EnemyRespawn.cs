using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int planetnum = ObjectPoolManager.Instance.EnemyPool.alloccount;
        int healnum = ObjectPoolManager.Instance.HealthPool.alloccount;
        int boostnum = ObjectPoolManager.Instance.BoostPool.alloccount;
        int bigonenum = ObjectPoolManager.Instance.BigonePool.alloccount;
        int blackholenum = ObjectPoolManager.Instance.BlackholePool.alloccount;

            for(int i=0;i<planetnum;i++){
            float scale;
            float dis;
            Vector2 enemyposition;
            dis = Random.Range(4f,28f);
            scale = Random.Range(2.0f,3.0f);
            enemyposition.x = Random.Range(-1.0f,1.0f);
            enemyposition.y = Random.Range(-1.0f,1.0f);
            enemyposition.Normalize();
            enemyposition = enemyposition*dis;
            GameObject tobj = ObjectPoolManager.Instance.EnemyPool.PopObj();
            tobj.transform.position = enemyposition;
            tobj.gameObject.transform.localScale = new Vector2(scale,scale); 
            }

            for(int i=0;i<healnum;i++){
            
            Vector2 Healposition;
            float dis;
            dis = Random.Range(4f,28f);
            Healposition.x = Random.Range(-1.0f,1.0f);
            Healposition.y = Random.Range(-1.0f,1.0f);
            Healposition.Normalize();
            Healposition = Healposition*dis;
            GameObject tobj1 = ObjectPoolManager.Instance.HealthPool.PopObj();
            tobj1.transform.position = Healposition;
 
            }

             for(int i=0;i<boostnum;i++){
            
            Vector2 Boostposition;
            float dis;
            dis = Random.Range(4f,28f);
            Boostposition.x = Random.Range(-1.0f,1.0f);
            Boostposition.y = Random.Range(-1.0f,1.0f);
            Boostposition.Normalize();
            Boostposition = Boostposition*dis;
            GameObject tobj2 = ObjectPoolManager.Instance.BoostPool.PopObj();
            tobj2.transform.position = Boostposition;
 
        }

         
            for(int i=0;i<bigonenum;i++){
            
            Vector2 Bigposition;
            float dis;
            dis = Random.Range(4f,28f);
            Bigposition.x = Random.Range(-1.0f,1.0f);
            Bigposition.y = Random.Range(-1.0f,1.0f);
            Bigposition.Normalize();
            Bigposition = Bigposition*dis;
            GameObject tobj3 = ObjectPoolManager.Instance.BigonePool.PopObj();
            tobj3.transform.GetChild(0).gameObject.SetActive(true);
            tobj3.transform.GetChild(1).gameObject.SetActive(true);
            tobj3.transform.position = Bigposition;
            Debug.Log("big one poped!");
        }


        for(int i=0;i<blackholenum;i++){
            
            Vector2 blackposition;
            float dis;
            dis = Random.Range(4f,28f);
            blackposition.x = Random.Range(-1f,1f);
            blackposition.y = Random.Range(-1f,1f);
            blackposition.Normalize();
            blackposition = blackposition*dis;
            GameObject tobj4 = ObjectPoolManager.Instance.BlackholePool.PopObj();
            tobj4.transform.position = blackposition;
            
            }
        
    }

    // Update is called once per frame
    void Update()
    {
    
        
    }
}
