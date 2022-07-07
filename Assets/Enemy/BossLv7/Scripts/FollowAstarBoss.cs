using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAstarBoss : MonoBehaviour
{
    public Transform player;
    public float speed = 27f;
    public float disLimit = 3f;

    // vi tri ngau nhien
    public float randPos = 0;


// Why???
    // private void Awake() {
    //     this.player = PlayerController.instance.transform;
    // }

    private void Awake() {
        this.randPos = Random.Range(-6, 6);
    }
    void Start()
    {
        // this.player = PlayerController.instance.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // this.Follow();
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Phitieu" || other.gameObject.tag == "Player"){
                this.Follow();
        }
    }
    void Follow(){

        Vector3 pos = this.player.position;
        // pos.x = this.randPos;

        Vector3 distance = pos - transform.position;
        
        if (distance.magnitude >= this.disLimit)
        {
            Vector3 targetPoint = pos - distance.normalized * this.disLimit;
            transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPoint, this.speed * Time.deltaTime);
        }
    }
}
