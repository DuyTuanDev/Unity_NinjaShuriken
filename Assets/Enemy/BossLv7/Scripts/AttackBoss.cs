using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBoss : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HpBossLv7.instance.current <= 0){
            Destroy(gameObject);
            
        }
    }
    private void OnTriggerStay2D(Collider2D other) {
        
        if(other.gameObject.tag == "Player"){
            animator.SetTrigger("Attack");
        }
        if(other.gameObject.tag == "Phitieu"){
            animator.SetTrigger("ChiuDam");
        }
    }
}
