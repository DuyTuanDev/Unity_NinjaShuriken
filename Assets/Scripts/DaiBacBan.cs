using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaiBacBan : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theSuken; // ban ra phi tieu
    public Transform nongsung; // vi tri ban
    public float shootTime;
    float nextShoot = 0f;
    Animator animator;
    private void Awake() {
        animator = GetComponentInChildren<Animator>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.tag == "Player" && Time.time > nextShoot){
            nextShoot = Time.time + shootTime;
            Instantiate(theSuken, nongsung.position, Quaternion.identity);
            animator.SetTrigger("canonShot");
        }
    }
}
