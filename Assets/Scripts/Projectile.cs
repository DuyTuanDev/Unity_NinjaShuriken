using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float bulletSpeed;
    Rigidbody2D myBody;
    Animator animator;
    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        // huong di phi tieu
        if(transform.localRotation.z > 0){
            myBody.AddForce(new Vector2(-1, 0) * bulletSpeed, ForceMode2D.Impulse);
        }
        else{
            myBody.AddForce(new Vector2(1,0) * bulletSpeed, ForceMode2D.Impulse);
        }
        // day vien dan

    }
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Phitieu" && other.gameObject.tag == "Tieu"){
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "ThanhGo"){
            
        }
    }
}
