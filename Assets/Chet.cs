using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chet : MonoBehaviour
{
    // Start is called before the first frame update
    GameController m_gc;
    void Start()
    {
        m_gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            m_gc.PlayerDied();
        }
    }
}
