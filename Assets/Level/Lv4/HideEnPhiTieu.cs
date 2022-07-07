using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideEnPhiTieu : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(enemy == null) return;
            enemy.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            if(enemy == null) return;
            enemy.SetActive(false);
        }
    }
}
