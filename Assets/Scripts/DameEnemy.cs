using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float dame;
    float dameRate = 0.5f;
    public float pushBackForce; // cham bi nhay len
    float nextDame; // thoi gian gay sat thuong
    PlayerController player;
    void Start()
    {
        nextDame = 0f;
        player = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player" && nextDame < Time.time){
            MauNvat thePlayerHp = other.gameObject.GetComponent<MauNvat>();
            thePlayerHp.addDamage(dame);
            
            nextDame = dameRate + Time.time;
            pushBack(other.transform);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
    }
    private void OnCollisionStay2D(Collision2D other) {
                if(other.gameObject.tag == "Player" && nextDame < Time.time){
            MauNvat thePlayerHp = other.gameObject.GetComponent<MauNvat>();
            thePlayerHp.addDamage(dame);
            
            nextDame = dameRate + Time.time;
            pushBack(other.transform);
        }
    }
    // cham la nhay len
    void pushBack(Transform pushedObject){ // tac dung len nhan vat
        Vector2 pushDrirection = new Vector2(0, (pushedObject.position.y - transform.position.y )).normalized; // normalized tra ve gia tri la 1 binhf thuong
        pushDrirection *= pushBackForce;
        
        Rigidbody2D pushRb = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRb.velocity = Vector2.zero;
        pushRb.AddForce(pushDrirection, ForceMode2D.Impulse);
    }
}
