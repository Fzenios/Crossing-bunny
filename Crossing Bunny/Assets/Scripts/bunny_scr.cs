using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bunny_scr : MonoBehaviour
{
    public float BunnySpeed = 5f;
    public Animator animator; 
    public Animator TimerAnimator;
    Rigidbody2D rb;
    Vector2 movement;
    public GameObject sxedia;
    public bool sxediatouch = false;
    public bool bunnycanmove = false;
    public bool bunnywait = false;
    public TextMeshProUGUI TextBox;
    public float TimerStart = 60;
    public PauseGame PauseGame;
    public GameObject Canvas;
    bool IsGameOver = false;
    public static bool LastLevel = false; 
    public GameObject Shark;
    public GameObject soublaki;
    public bool EndingScene = false;
    public GameObject BoxColliders;
    
    private void Start() 
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        //PolygonCollider = GetComponent<PolygonCollider2D>();
        //CaptuleCollider = GetComponent<CapsuleCollider2D>();
    }
    void Update()
    {
        if(bunnywait)
        {
            if(bunnycanmove)
            { 
                movement.x = Input.GetAxis("right");
                movement.y = Input.GetAxis("up");
                animator.SetFloat("Horizontal",movement.x);
                animator.SetFloat("Vertical",movement.y);
                animator.SetFloat("Speed",movement.sqrMagnitude);

                TimerStart -= Time.deltaTime;
            }
        }
        if(transform.position.y > 0)
        GetComponent<SpriteRenderer>().sortingLayerName = "Enemies";
        
        TextBox.text = Mathf.Round(TimerStart).ToString();
        
        if(TimerStart <= 0 && !IsGameOver)
        {
            IsGameOver = true;
            Time.timeScale = 0f;
            bunnycanmove = false; 
            PauseGame.ChangePause();
            Canvas.transform.GetChild(3).gameObject.SetActive(true);
            GetComponent<AudioSource>().Pause();          
        }
        if(TimerStart <= 10 && !IsGameOver)
        TimerAnimator.SetBool("LastSeconds",true);
    }

    void FixedUpdate() 
    {
        if(bunnycanmove)
        rb.MovePosition(rb.position + movement * BunnySpeed * Time.deltaTime);        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Enemy")
        {
            Time.timeScale = 0f;
            bunnycanmove = false; 
            PauseGame.ChangePause();
            Canvas.transform.GetChild(2).gameObject.SetActive(true);
            GetComponent<AudioSource>().Pause();
            LastLevel = false;
        }   
        if(other.tag == "EnemySea")
        {
            Time.timeScale = 0f;
            bunnycanmove = false; 
            PauseGame.ChangePause();
            Canvas.transform.GetChild(1).gameObject.SetActive(true);
            LastLevel = false;
        }   
        if(other.tag == "Souvlaki" && !LastLevel)
        {
            Time.timeScale = 0f;
            GetComponent<AudioSource>().Pause();
            bunnycanmove = false; 
            PauseGame.ChangePause();
            Canvas.transform.GetChild(4).gameObject.SetActive(true);
        }
        if(other.tag == "Souvlaki" && LastLevel)
        {
            Vector3 SharkPosition = new Vector3(-0.11f,4.84f,0);
            //Destroy(soublaki);
            BoxColliders.GetComponent<PolygonCollider2D>().isTrigger = false;
            soublaki.SetActive(false);
            Invoke("DisableBunny",0.5f);
            Instantiate(Shark, SharkPosition, Quaternion.identity);
            PauseGame.ChangePause();
            bunnycanmove = false; 
            Invoke("LastScene",4f);    
        }
        if(other.tag == "Sxedia")
        {
            sxediatouch = true;
            //transform.parent = other.transform;
        }       
        if(other.tag == "Sea" && !sxediatouch)
        {
            Time.timeScale = 0f;
            bunnycanmove = false; 
            PauseGame.ChangePause();
            GetComponent<AudioSource>().Pause();
            Canvas.transform.GetChild(1).gameObject.SetActive(true);
            LastLevel = false;
        }
    }

    void OnTriggerStay2D(Collider2D other) 
    {
        if(other.tag == "Sxedia")
        {
            sxediatouch = true;
           // transform.parent = other.transform; 
        } 
        if(other.tag == "Sea" && !sxediatouch)
        {
            Time.timeScale = 0f;
            bunnycanmove = false; 
            PauseGame.ChangePause();
            GetComponent<AudioSource>().Pause();
            Canvas.transform.GetChild(1).gameObject.SetActive(true);
        }    
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == "Sxedia")
        {
            sxediatouch = false;
          //  transform.parent = null;
        }
    }

    void DisableBunny()
    {
        gameObject.SetActive(false);
    } 

    void LastScene()
    {
        Canvas.transform.GetChild(6).gameObject.SetActive(true);
        LastLevel = false;
        Time.timeScale = 0f;
    }
}
