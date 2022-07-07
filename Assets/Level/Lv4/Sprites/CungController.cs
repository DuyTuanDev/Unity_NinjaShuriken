using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CungController : MonoBehaviour
{
    public Vector3 target;
    public float moveSpeed = 5;
	// Use this for initialization
	Rigidbody2D enemyRb;
	void Start () {
		enemyRb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((transform.position - target) * moveSpeed * Time.deltaTime * -1);
		Change();
    }
	void Change(){
            Vector3 temp = transform.localScale;
            if(transform.position.x >= 0){
                temp.x =1f;
            }
            else if(transform.position.x <= -2){
                temp.x = -1f;
            }
            transform.localScale = temp;
        }
	private void OnTriggerEnter2D(Collider2D other) {
		if(other.gameObject.tag == "Ground" && other.gameObject.tag == "Player"){
			Destroy(gameObject);
			//enemyRb.velocity = new Vector2 (0,0);
		}
	}
	private void OnCollisionStay2D(Collision2D other) {

	}
}
