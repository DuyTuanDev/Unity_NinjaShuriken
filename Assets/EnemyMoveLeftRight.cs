using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeftRight : MonoBehaviour
{
    // Start is called before the first frame update
    EnemyHp e_hp;
    void Start()
    {
        e_hp = FindObjectOfType<EnemyHp>();

        this.rmybody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // di chuyen
        rmybody.velocity = new Vector2(transform.localScale.x,0) * pressHorizontal;
        // kiem tra huong xoay
        Change();
        // if(EnemyHp.instance.current <= 0){
        //     Destroy(gameObject);
        // }
    }
    /// enemy di chuyen
    public float pressHorizontal = 5f;
    protected Rigidbody2D rmybody;
    bool collision;
    [SerializeField]
    Transform start, end;
    void Change(){
        collision = Physics2D.Linecast(start.position, end.position, 1 <<LayerMask.NameToLayer("Ground"));
        Debug.DrawLine(start.position, end.position, Color.green);
        
        if(!collision){
            Vector3 temp = transform.localScale;
            // if(transform.position.x >= 1){
            //     temp.x =-1f;
            // }
            // else if(transform.position.x <= -1.5){
            //     temp.x = 1f;
            // }
            if(temp.x == 1f){
                temp.x =-1f;
            }
            else {
                temp.x = 1f;
            }
            transform.localScale = temp;
        }
    }
    

    Animator animator;
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Debug.Log("Cham");
            pressHorizontal = 0;
            //animator.SetTrigger("Ban");
        }
        // if(other.gameObject.tag == "Phitieu"){
            
        //     animator.SetTrigger("BiDanh");
        // }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            pressHorizontal = 5;
        }
        // if(other.gameObject.tag == "Phitieu"){
           
        // }
    }    
}
