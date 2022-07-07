using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnEnemy : MonoBehaviour
{
    // Start is called before the first frame update
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
}
