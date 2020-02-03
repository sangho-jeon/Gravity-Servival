using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : Planet
{
 
    
    private Vector3 rotateAxis;
    private float rotatespeed=50.0f;
    private Vector3 Dist;
    //private Vector3 rotateAxis;

    // Start is called before the first frame update    
    void Start()
    {
        float x= Random.Range(-0.7f,0.7f);
        float y= Random.Range(-0.7f,0.7f);
        rotateAxis = transform.position - new Vector3(x,y,0);
    }

    // Update is called once per frame
    
    void OnTriggerEnter2D(Collider2D player){
        if(player.gameObject.CompareTag("player")){
            this.push();
            Recreate();
        }
    }
     void FixedUpdate(){
        Dist = GameManager.Instance.mainplayer.transform.position-gameObject.transform.position;
        transform.RotateAround(rotateAxis, new Vector3(0,0,1), rotatespeed*Time.deltaTime);
       
    }

    void Recreate(){
        float distance;
        Vector3 pos;
        GameObject tobj = Pool.PopObj();
        distance = Random.Range(4.0f, 28.0f);
        pos.x = Random.Range(-1.0f, 1.0f);
        pos.y = Random.Range(-1.0f, 1.0f);
        pos.z = 0;

        float x= Random.Range(-0.7f,0.7f);
        float y= Random.Range(-0.7f,0.7f);
        pos.Normalize();
        tobj.transform.position =GameManager.Instance.mainplayer.transform.position+pos*distance;
        rotateAxis = tobj.transform.position - new Vector3(x,y,0);

    }
    public override void  Respawn(Vector3 Dist){
            Vector3 pos;
            GameObject tobj = Pool.PopObj();
            pos.x = Random.Range(0.5f, 0.7f);
            pos.y = Random.Range(0.5f, 0.7f);
            pos.z = 0f;
            float x= Random.Range(-0.7f,0.7f);
            float y= Random.Range(-0.7f,0.7f);
            
            tobj.transform.position = GameManager.Instance.mainplayer.transform.position+Dist;
            rotateAxis = tobj.transform.position - new Vector3(x,y,0);
    }
   
   
/*
    public override void Respawn()
    {

            Vector3 enemyposition;
            int Case = Random.Range(1,4);
            GameObject tobj = Pool.PopObj();
            float x= Random.Range(0.5f,0.7f);
            float y= Random.Range(0.5f,0.7f);
          


            
            //GameObject tobj = ObjectPoolManager.Instance.EnemyPool.PopObj();
            switch(Case)
            {
                case 1:
                    enemyposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,20.0f);
                    enemyposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,-5.0f);
                    enemyposition.z = 0;
                    tobj.transform.position = enemyposition;
                    rotateAxis = enemyposition - new Vector3(x,y,0);
                    break;
                case 2:
                    enemyposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,20.0f);
                    enemyposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(5.0f,28.0f);
                    enemyposition.z = 0;
                    tobj.transform.position = enemyposition;
                    rotateAxis = enemyposition - new Vector3(x,y,0);
                    break;
                case 3:
                    enemyposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(-20.0f,-3.0f);
                    enemyposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,28.0f);
                    enemyposition.z = 0;
                    tobj.transform.position = enemyposition;
                    rotateAxis = enemyposition - new Vector3(x,y,0);
                    break;
                case 4:
                    enemyposition.x = GameManager.Instance.mainplayer.transform.position.x+Random.Range(3.0f,20.0f);
                    enemyposition.y = GameManager.Instance.mainplayer.transform.position.y+Random.Range(-28.0f,28.0f);
                    enemyposition.z = 0;
                    tobj.transform.position = enemyposition;
                    rotateAxis = enemyposition - new Vector3(x,y,0);
                    break; 
                
            }
            
    }
    */

}
   
    

    




