using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : PoolableObject
{
    private Vector3 Dis;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //float Dis = Vector2.Distance(GameManager.Instance.mainplayer.transform.position,gameObject.transform.position);
        Dis = GameManager.Instance.mainplayer.transform.position-gameObject.transform.position;
        if(Mathf.Abs(Dis.magnitude)>28){
            
            this.push();
            Respawn(Dis);
        }

    }

    public virtual void  Respawn(Vector3 Dis){
            GameObject tobj = Pool.PopObj();
            tobj.transform.position = GameManager.Instance.mainplayer.transform.position+Dis;
    }

    
    
}
