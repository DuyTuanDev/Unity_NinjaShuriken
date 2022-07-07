using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SukenController : MonoBehaviour
{
    // Start is called before the first frame update
    public float sukenHight;
    public float sukenLow;
    public float sukenAngle;
    Rigidbody2D canonRb;
    private void Awake() {
        canonRb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        canonRb.AddForce(new Vector2(Random.Range(-sukenAngle, sukenAngle), Random.Range(sukenLow, sukenHight)), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnCollisionStay2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
