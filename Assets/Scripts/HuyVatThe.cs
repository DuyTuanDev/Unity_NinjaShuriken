using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HuyVatThe : MonoBehaviour
{
    public float wpDame;
    // Start is called before the first frame update
    public float TimeTonTai;

    void Start()
    {
        Destroy(gameObject, TimeTonTai);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // private void OnTriggerStay2D(Collider2D other) {
    //     if(other.gameObject.layer == LayerMask.NameToLayer("enemy")){
    //         EnemyHp hurtEnemy = other.gameObject.GetComponent<EnemyHp>();
    //         hurtEnemy.addDamage(wpDame);
    //         Debug.Log(wpDame);
    //         Debug.Log("Cham ");

    //     }
    // }
    private void OnTriggerEnter2D(Collider2D other) {
        //if(other.gameObject.layer == LayerMask.NameToLayer("enemy")){
            if(other.gameObject.tag == "ThanhGo"){ 
            EnemyHp hurtEnemy = other.gameObject.GetComponent<EnemyHp>();
        
            hurtEnemy.addDamage(wpDame);
        
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Boss"){ 
            HpBossLv7 hurtEnemy = other.gameObject.GetComponent<HpBossLv7>();
            hurtEnemy.addDamage(wpDame);
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "SmallBoss"){ 
            
            HpEnFlBoss hurtEnemyFl = other.gameObject.GetComponent<HpEnFlBoss>();
           
            hurtEnemyFl.addDamage(wpDame);
            // Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Phitieu"){
            Destroy(other.gameObject);
        }
    }
}
