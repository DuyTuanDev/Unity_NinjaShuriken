using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject boom;
    public float minBoomTime = 2;
    public float maxBoomTime = 4;
    private float boomTime = 0;
    private float lastBoomTime = 0;
    private GameObject Sheep;
	// Use this for initialization
	void Start () {
        UpdateBoomTime();
        Sheep = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	    // if (Time.time >= lastBoomTime + boomTime)
        // {
        //     ThroughBoom();
        // }
	}
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if (Time.time >= lastBoomTime + boomTime - 0.5)
            {
                ThroughBoom();
            }
            if(facingRight && other.transform.position.x > transform.position.x){
                flip();
            }
            if (!facingRight && other.transform.position.x < transform.position.x ){
                flip();
            }
            canFlip = false; 
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player" && !facingRight){
            //canFlip = false;
            flip();
            //canFlip = true;
        }
        // if(other.gameObject.tag == "Player" && facingRight){
        //     //canFlip = false;
        //     flip();
        //     //canFlip = true;
        // }
    }
    public GameObject enemyGraphic;
    bool facingRight = true;
    // float facingTime = 5f; 
    // float nextFlip = 0f; // vao lat luon
    bool canFlip = true;
    void flip(){
        if(canFlip)
            return;
        facingRight = !facingRight;
        if(enemyGraphic == null) return;
        Vector3 theScale = enemyGraphic.transform.localScale;
        theScale.x *= -1;
        enemyGraphic.transform.localScale = theScale;
    }
    void UpdateBoomTime()
    {
        lastBoomTime = Time.time;
        boomTime = Random.Range(minBoomTime, maxBoomTime + 1);
    }

    void ThroughBoom()
    {
        if(boom == null) return;
        GameObject bom = Instantiate(boom, transform.position, Quaternion.identity) as GameObject;

        bom.GetComponent<SkEnemyController>().target = Sheep.transform.position;

        UpdateBoomTime();
    }
}
