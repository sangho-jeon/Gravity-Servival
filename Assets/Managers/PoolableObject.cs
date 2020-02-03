using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolableObject : MonoBehaviour
{
    protected ObjectPool Pool;
    public virtual void Create(ObjectPool pool){
        Pool = pool;
        Debug.Log("this object is in "+ Pool);
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    public virtual void push(){
        Pool.PushObj(this);
    }
   
 
}
