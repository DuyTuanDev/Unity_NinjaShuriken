using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkEnemyController : MonoBehaviour
{
    public Vector3 target;
    public float moveSpeed = 5;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate((transform.position - target) * moveSpeed * Time.deltaTime * -1);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
        if(other.gameObject.tag == "Phitieu" && other.gameObject.tag == "PhiTieuEnemy"){
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        
    }
}
