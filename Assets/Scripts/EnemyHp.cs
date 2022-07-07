using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHp : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHp;
    static public EnemyHp instance;
    public float current;
    // hieu ung khi chet


//hien mau enemy
    public Slider enemyHp;
    GameController m_gc;
    void Start()
    {
        EnemyHp.instance = this;
        current = maxHp;
        enemyHp.maxValue = maxHp;
        enemyHp.value = maxHp;
        // Dem Enemy de qua man
        // if(DkLv1.intance != null){
        //     DkLv1.intance.collectable++;
        // }
        // if(DkLv2.intance != null){
        //     DkLv2.intance.collectable++;
        // }
        // if(DkLv3.intance != null){
        //     DkLv3.intance.collectable++;
        // }
        // // if(DkLv4.intance != null){
        // //     DkLv4.intance.collectable++;
        // // }
        // if(DkLv5.intance != null){
        //     DkLv5.intance.collectable++;
        // }
        // if(DkLv6.intance != null){
        //     DkLv6.intance.collectable++;
        // }
        // if(DkLv7.intance != null){
        //     DkLv7.intance.collectable++;
        // }
        m_gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addDamage(float dame){
        enemyHp.gameObject.SetActive(true);
        EfManage.instance.SpawnVFX("mau", transform.position, transform.rotation);
        current -= dame;
        enemyHp.value = current;
        if(current <= 0){
            makeDead();
            Destroy(gameObject);
            m_gc.ScoreIncrement();
            // Giet enemy de qua man
            // if(DkLv1.intance != null){
            //     DkLv1.intance.Decrement();
            // }
            // if(DkLv2.intance != null){
            //     DkLv2.intance.Decrement();
            // }
            // if(DkLv3.intance != null){
            //     DkLv3.intance.Decrement();
            // }
            // // if(DkLv4.intance != null){
            // //     DkLv4.intance.Decrement();
            // // }
            // if(DkLv5.intance != null){
            //     DkLv5.intance.Decrement();
            // }
            // if(DkLv6.intance != null){
            //     DkLv6.intance.Decrement();
            // }
            // if(DkLv7.intance != null){
            //     DkLv7.intance.Decrement();
            // }
        }
    }
    public Transform item;
    void makeDead(){
        // an di object
        //gameObject.SetActive(false);

        // roi ra vien Hp (item), ban do
        if(banDo){
            Instantiate(BanDoNextLv,item.transform.position, transform.rotation);
        }
        
        if(drop){
            Instantiate(Hp,transform.position, transform.rotation);
            
        }
    }
    // private void OnTriggerEnter2D(Collider2D other) {
    //     if(other.gameObject.tag == "Phitieu"){
    //         Destroy(other.gameObject);
    //     }
    // }


    // khi enemy chet roi ra mau
    public bool drop;
    public bool banDo;
    public GameObject Hp;
    public GameObject BanDoNextLv;
}
