using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoiTraiTim : MonoBehaviour
{
    // Start is called before the first frame update
    // public int hearltAmount;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            // MauNvat thePlayerHp = other.gameObject.GetComponent<MauNvat>();
            // thePlayerHp.addHp(hearltAmount);
            Destroy(gameObject);
        }
    }
}
