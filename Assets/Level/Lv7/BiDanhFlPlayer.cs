using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiDanhFlPlayer : MonoBehaviour
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
        // if(HpEnFlBoss.instance.current <= 0){
        //     Destroy(gameObject);
        // }
    }
    public Transform player;
    public float speed = 27f;
    public float disLimit = 3f;
    bool fl = false;
    private void FixedUpdate() {
        if(fl){
            this.Follow();
        }
        

    }
    private void OnTriggerStay2D(Collider2D other) {
        if(animator == null) return;
        if(other.gameObject.tag == "Player"){
            animator.SetTrigger("Attack");
        }
        if(other.gameObject.tag == "Phitieu"){
            fl = true;
        }
    }
    void Follow(){

        Vector3 pos = this.player.position;
        // pos.x = this.randPos;

        Vector3 distance = pos - transform.position;
        
        if (distance.magnitude >= this.disLimit)
        {   
            animator.SetTrigger("Dichuyen");
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
