using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newboost : MonoBehaviour
{
    Vector3 orbitpos;
    float rotatespeed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        orbitpos = gameObject.transform.parent.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        orbitpos = gameObject.transform.parent.gameObject.transform.position;
    }
    void OnTriggerEnter2D(Collider2D player){
        if(player.gameObject.CompareTag("player")){
            gameObject.SetActive(false);
        }
    }

    void FixedUpdate(){
        Orbit();
    }

    void Orbit(){
        
        transform.RotateAround(orbitpos, new Vector3(0,0,1), rotatespeed*Time.deltaTime);
    }


}
