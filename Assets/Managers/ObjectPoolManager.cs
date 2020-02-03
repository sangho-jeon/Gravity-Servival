using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolManager : MonoBehaviour
{
    
    public static ObjectPoolManager Instance{
        get{
            return instance;
        }
    }
    private static ObjectPoolManager instance;
    // Start is called before the first frame update
    void Awake(){
        if(instance){
            DestroyImmediate(gameObject);
            return; 
        }
        else{
            instance = this;
        }
    }
    public ObjectPool EnemyPool;
    public ObjectPool HealthPool;
    public ObjectPool BoostPool;
    public ObjectPool BigonePool;
    public ObjectPool BlackholePool;
    public ObjectPool AsteroidPool;
    
}
