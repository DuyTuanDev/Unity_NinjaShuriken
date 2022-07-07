using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed;
    Rigidbody2D enemyRb;
    public GameObject phitieu;
    Animator enemyani;
    // dichuyen theo huong nhan vat
    public GameObject enemyGraphic;
    bool facingRight = true;
    float facingTime = 5f; 
    float nextFlip = 0f; // vao lat luon
    bool canFlip = true; // chua cham lat lien tuc
    void Awake() {
        enemyRb = GetComponent<Rigidbody2D>();
        enemyani =  GetComponentInChildren<Animator>();    
    }
    void Start()
    {
        
    }
    // Update is called once per frame
    
    void Update()
    {
        if(Time.time > nextFlip){ // Thoi gian cua game > lan lat tiep theo 5f
            nextFlip = Time.time + facingTime;
            flip();
        }    
        // if(EnemyHp.instance.current <= 0){
        //     Destroy(gameObject);
        // }
        
    }
    void flip(){
        if(!canFlip)
            return;
        facingRight = !facingRight;
        if(enemyGraphic == null) return;
        Vector3 theScale = enemyGraphic.transform.localScale;
        theScale.x *= -1;
        enemyGraphic.transform.localScale = theScale;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" ){

        }
        // destroy VaChamEnemy
        if(other.tag == "chet"){
            Destroy(gameObject);
        }
  
    }
    public Transform vitri;
    float fireRate = 0.3f;
    float nextFire = 0;
    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player"){
            if(facingRight && other.transform.position.x < transform.position.x){
                flip();
            }
            else if (!facingRight && other.transform.position.x > transform.position.x ){
                flip();
            }
            canFlip = false; 
            Debug.Log("Di chuyen");
            if(!facingRight){
                enemyRb.AddForce(new Vector2(-1, 0) * enemySpeed);
                fireBullet();
            }
            else{
                enemyRb.AddForce(new Vector2(1, 0) * enemySpeed);
                fireBullet();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            canFlip = true;
            enemyRb.velocity = new Vector2 (0,0);
        }
    }
    void fireBullet(){
        if(Time.time > nextFire){
            nextFire = Time.time + fireRate;
            if(vitri == null) return;
            if(facingRight){
                //Instantiate(phitieu, vitri.position, Quaternion.Euler(new Vector3(0,0,0)));
                Instantiate(phitieu, vitri.position, Quaternion.Euler(new Vector3(0,0,0)));

            }
            else if(!facingRight){
                //Instantiate(phitieu, vitri.position, Quaternion.Euler(new Vector3(0,0,160)));
                Instantiate(phitieu, vitri.position, Quaternion.Euler(new Vector3(0,0,160)));

            }
        }
    }    
    public Transform player;

    // bool collision;
    // [SerializeField]
    // Transform start, end;
    // void Change(){
    //     collision = Physics2D.Linecast(start.position, end.position, 1 <<LayerMask.NameToLayer("Ground"));
    //     Debug.DrawLine(start.position, end.position, Color.green);
        
    //     if(!collision){
    //         Vector3 temp = transform.localScale;
    //         // if(transform.position.x >= 1){
    //         //     temp.x =-1f;
    //         // }
    //         // else if(transform.position.x <= -1.5){
    //         //     temp.x = 1f;
    //         // }
    //         if(temp.x == 1f){
    //             temp.x =-1f;
    //         }
    //         else {
    //             temp.x = 1f;
    //         }
    //         transform.localScale = temp;
    //     }
    // }
}
