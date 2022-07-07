using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBanCung : MonoBehaviour
{
    public GameObject boom;
    public float minBoomTime = 2;
    public float maxBoomTime = 4;
    private float boomTime = 0;
    private float lastBoomTime = 0;
    private GameObject Sheep;
    Animator anni;

	// Use this for initialization
	void Start () {
        UpdateBoomTime();
        Sheep = GameObject.FindGameObjectWithTag("Player");
        anni = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    // if (Time.time >= lastBoomTime + boomTime)
        // {
        //     ThroughBoom();
        // }



	}
    // cham vong la ban
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if (Time.time >= lastBoomTime + boomTime)
            {
                ThroughBoom();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.tag == "Player"){
            if (Time.time >= lastBoomTime + boomTime)
            {
                ThroughBoom();
            }
        }
    }
    void UpdateBoomTime()
    {
        lastBoomTime = Time.time;
        boomTime = Random.Range(minBoomTime, maxBoomTime + 1);
    }

    void ThroughBoom()
    {
        anni.SetTrigger("Ban");
        GameObject bom = Instantiate(boom, transform.position, Quaternion.identity) as GameObject;

        bom.GetComponent<CungController>().target = Sheep.transform.position;

        UpdateBoomTime();
    }


}
