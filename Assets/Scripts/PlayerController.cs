using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    static public PlayerController intances;
    public float maxSpeed;
    public float jump;
    Rigidbody2D myBody;
    Animator myAni;
    bool quaymat;
    bool grounder;

    //bien ban phi tieu
    public Transform vitriphitieu;
    public GameObject bullet;
    
    float fireRate = 0.2f;
    float nextFire = 0;
    private void Awake() {
        PlayerController.intances = this;
    }

    void Start()
    {
        
        Application.targetFrameRate = 600;
        myBody = GetComponent<Rigidbody2D>();
        myAni = GetComponent<Animator>();
        quaymat = true;
        
    }
    int dung;
    private void Update() {
        dung = PlayerPrefs.GetInt("dung");
        if(dung == 5){
            int sl = PlayerPrefs.GetInt("slhp");
                sl++;   
            PlayerPrefs.SetInt("slhp", sl);
            UiManager.instance.BinhHp(""+ sl);
            dung = 0;
            PlayerPrefs.SetInt("dung", 0);
        }
        if(dung > 5)
        {
             PlayerPrefs.SetInt("dung", 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "BanDo"){
            dung++;
            PlayerPrefs.SetInt("dung", dung);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        // #if UNITY_ANDROID
        //     if(Application.platform == RuntimePlatform.Android)
        //     {
        //         MoveButton();
        //     }
        // #endif
    
        // #if UNITY_EDITOR
        //     if (Application.platform == RuntimePlatform.WindowsEditor)
        //     {
        //         MovePlayer();
        //     }
        // #endif
        MovePlayer();
        MoveButton();
        _Move();
    }
    public void MovePlayer(){
        float move = Input.GetAxis("Horizontal");
        myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
        myAni.SetFloat("speed", Mathf.Abs(move));
        if(move > 0 && !quaymat){
            flip();
        }
        else if(move < 0 && quaymat){
            flip();
        }
        if(Input.GetKey(KeyCode.W)){
            if(grounder){
                grounder = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jump);
            }
        }

    // // ban tu phim
    //     if(Input.GetAxisRaw("Fire1") > 0){ // nhan chuot trai de ban
    //         fireBullet();
    //         myAni.SetTrigger("Ban");
    //     }
    }
    void flip(){
        quaymat = !quaymat;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    // kiem tra dk nhay
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ground"){
            grounder = true;
        }
    }
    // chuc nang ban quay mat
    void fireBullet(){
        if(Time.time > nextFire){
            nextFire = Time.time + fireRate;
            // am thanh
            if(quaymat){
                myAni.SetTrigger("AtackPl");
                Instantiate(bullet, vitriphitieu.position, Quaternion.Euler(new Vector3(0,0,0)));
            }
            else if(!quaymat){
                myAni.SetTrigger("AtackPl");
                Instantiate(bullet, vitriphitieu.position, Quaternion.Euler(new Vector3(0,0,160)));
            }
        }
    }
        // move button    
    float speed = 6;
    void MoveButton(){
        if(moveLeft)
        {
            float move = -1;
            myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
            myAni.SetFloat("speed", Mathf.Abs(move));
            if(move > 0 && !quaymat){
                flip();
            }
            else if(move < 0 && quaymat){
                flip();
            }
        }
        if(moveRight)
        {
            float move = 1;
            myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
            myAni.SetFloat("speed", Mathf.Abs(move));
            if(move > 0 && !quaymat){
                flip();
            }
            else if(move < 0 && quaymat){
                flip();
            }
        }
        if(Nhay)
        {
            if(grounder){
                grounder = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jump);
            }
        }
        if(Attack)
        {
            fireBullet();
            myAni.SetTrigger("Ban");
        } 
    }
    bool moveLeft, moveRight, Nhay, Attack;
    public void StopMoving(){
        this.moveLeft = false;
        this.moveRight = false;
        this.Nhay = false;
        this.Attack = false;
    }
    public void SetMoveLeft( bool moveLeft){
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
        
    }  
    public void SetNhay(bool Nhay){
        this.Nhay = Nhay;
    }
    public void SetAttack(bool Attack){
        this.Attack = Attack;
    }
    // move Joystick
    [SerializeField]
    Joystick Joystick;
    void _Move(){
        float x = Joystick.Horizontal * speed ;
        float y = Joystick.Vertical * speed ;
        // myBody.velocity = new Vector2(x, myBody.velocity.y);
        // if(x < 0){
        //     Sprite.flipX = false;
        // }
        // else if(x > 0){
        //     Sprite.flipX = !false;
        // }
        // else if (x == 0){ 
        // }
        if(x < -3){
            float move = -1;
            myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
            myAni.SetFloat("speed", Mathf.Abs(x));
            if(move > 0 && !quaymat){
                flip();
            }
            else if(move < 0 && quaymat){
                flip();
            }
        }
        if(x > 3){
            float move = 1;
            myBody.velocity = new Vector2(move * maxSpeed, myBody.velocity.y);
            myAni.SetFloat("speed", Mathf.Abs(x));
            if(move > 0 && !quaymat){
                flip();
            }
            else if(move < 0 && quaymat){
                flip();
            }
        }
        if(y>3){
            if(grounder){
                grounder = false;
                myBody.velocity = new Vector2(myBody.velocity.x, jump);
            }
        }
    }
}
