using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{

    private GameObject target;
    private Rigidbody2D rgbd;
    float z, DelayTime;
    
  

    void Start(){
        Screen.SetResolution(580, 960, FullScreenMode.Windowed);
        Screen.fullScreen = false;

        target = GameManager.Instance.mainplayer.gameObject;
        rgbd = target.gameObject.GetComponent<Rigidbody2D>();
        z =-9.066406f;
        DelayTime = 1.05f;

    }
    void Update () {
        float speed = rgbd.velocity.magnitude*5;
        if(speed>12){
            speed = 12f;
        }
        Vector3 FixedPos =
            new Vector3(
            target.transform.position.x,
            target.transform.position.y,
            z-speed
            );

        transform.position = Vector3.Lerp(transform.position, FixedPos, Time.deltaTime * DelayTime);
    }





}
