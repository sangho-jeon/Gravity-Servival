using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public int alloccount{
        get{
            return allocateCount;
            }
    }
    [SerializeField]
    private PoolableObject poolObj;
    [SerializeField]
    private int allocateCount;
    private Queue<PoolableObject> stack = new Queue<PoolableObject>();

    // Start is called before the first frame update
    void Awake()
    {
        Allocate();
    }
    void Allocate(){
        for(int i=0; i<allocateCount;i++){
            PoolableObject tobj = Instantiate(poolObj);
            tobj.Create(this);
            stack.Enqueue(tobj); 
        }
        
    }
    public GameObject PopObj(){
        if(stack==null){
            Debug.Log("stack empty!!");
        }
        PoolableObject obj = stack.Dequeue();
        obj.gameObject.SetActive(true);
        return obj.gameObject;
    }
    public void PushObj(PoolableObject obj){
        obj.gameObject.SetActive(false);
        stack.Enqueue(obj);
    }
}
