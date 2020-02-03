using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : PoolableObject
{
    private Vector3 offset;
    private Vector3 targetpos;
    private Rigidbody2D rgbd;
    private Vector3 dir;
    [SerializeField]
    private float shootingSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
        float x = Random.Range(-1f,1f);
        float y = Random.Range(-1f,1f);
        offset.x=x;
        offset.y=y;
        offset.z=0;
        offset.Normalize();

    }
    

    // Update is called once per frame
    void Update()
    {
        transform.right = rgbd.velocity;
          
    }
    
    void OnEnable(){
        transform.position = targetpos+offset*7;
        StartCoroutine(Shoot());
    }
    void OnTriggerEnter2D(Collider2D player){
        if(player.gameObject.CompareTag("player")){
            this.push();
        }
    }

    IEnumerator Shoot(){
        targetpos = GameManager.Instance.mainplayer.transform.position;
        dir = targetpos-transform.position ;
        dir.Normalize();
        rgbd.AddForce(dir*shootingSpeed);
        yield return new WaitForSeconds(40f);
        this.push();
        
    }
    void OnBecameInvisible(){
        this.push();
    }
    
}
