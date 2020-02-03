using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    private new SpriteRenderer renderer;
    private Color playercolor;
    public Text Score;
    public int playerScore = 0;
    public float PlayerHp = 1.0f;
    private Rigidbody2D rb2d;
    public float movingSpeed = 20.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        renderer = GetComponent<SpriteRenderer>();
        playercolor = renderer.color;
        StartCoroutine(Healthdecrease());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.LeftArrow)==true){
            rb2d.AddForce(Vector2.left*movingSpeed*Time.fixedDeltaTime);
            PlayerHp -= 0.001f;
        }
        else if(Input.GetKey(KeyCode.RightArrow)==true){
            rb2d.AddForce(Vector2.right*movingSpeed*Time.fixedDeltaTime);
            PlayerHp -= 0.001f;
        }
        else if(Input.GetKey(KeyCode.UpArrow)==true){
            rb2d.AddForce(Vector2.up*movingSpeed*Time.fixedDeltaTime);
            PlayerHp -= 0.001f;
        }
        else if(Input.GetKey(KeyCode.DownArrow)==true){
            rb2d.AddForce(Vector2.down*movingSpeed*Time.fixedDeltaTime);
            PlayerHp -= 0.001f;
        }

        if(movingSpeed>100f){
            movingSpeed = 100f;
        }
        playerScore+=1;
        Score.text = playerScore.ToString();


        if(PlayerHp<=0){
            SceneManager.LoadScene("EndScene");
        }


        
        
    }
    void OnTriggerStay2D(Collider2D planet){
         if(planet.gameObject.CompareTag("planet")){
            float gravityscale = planet.gameObject.transform.localScale.x/3;
            Vector3 enemypos = planet.gameObject.transform.position;
            Vector3 forcedir = enemypos - gameObject.transform.position;
            forcedir.Normalize();

            rb2d.AddForce(forcedir*(gravityscale));
        }
        if(planet.gameObject.CompareTag("blackhole")){
            float gravityscale = planet.gameObject.transform.localScale.x*2;
            Vector3 enemypos = planet.gameObject.transform.position;
            Vector3 forcedir = enemypos - gameObject.transform.position;
            forcedir.Normalize();
            rb2d.AddForce(forcedir*(gravityscale));

        }
    }
    void OnTriggerEnter2D(Collider2D boost){
        if(boost.gameObject.CompareTag("Boost")){
            StartCoroutine(BoostOn());
        }
        else if(boost.gameObject.CompareTag("asteroid")){
            StartCoroutine(Enemycollided());
        }

    }
    IEnumerator Healthdecrease(){
        while(PlayerHp>0){
            PlayerHp-=0.01f;
            yield return new WaitForSeconds(1f);
        }
    }
    IEnumerator Enemycollided(){
        Color tcolor = playercolor;
        renderer.color = Color.red;
        PlayerHp -=0.2f;
        yield return new WaitForSeconds(1f);
        renderer.color = tcolor;
    }

    IEnumerator BoostOn(){
        Color tcolor = playercolor;
        renderer.color = Color.cyan;
        Debug.Log("fucking boosted");
        GameManager.Instance.mainplayer.movingSpeed += 30.5f;
        
        yield return new WaitForSeconds(3f);
        Debug.Log("boost end");
        renderer.color  = tcolor;
        GameManager.Instance.mainplayer.movingSpeed -= 30.5f;
        

      
    }
   


   
}
