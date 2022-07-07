using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanDo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        if(DkLv1.intance != null){
            DkLv1.intance.collectable++;
        }
        if(DkLv2.intance != null){
            DkLv2.intance.collectable++;
        }
        if(DkLv3.intance != null){
            DkLv3.intance.collectable++;
        }
        if(DkLv4.intance != null){
            DkLv4.intance.collectable++;
        }
        if(DkLv5.intance != null){
            DkLv5.intance.collectable++;
        }
        if(DkLv6.intance != null){
            DkLv6.intance.collectable++;
        }
        if(DkLv7.intance != null){
            DkLv7.intance.collectable++;
        }
    }

    // Update is called once per frame

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            
            if(DkLv1.intance != null){
                DkLv1.intance.Decrement();
            }
            if(DkLv2.intance != null){
                DkLv2.intance.Decrement();
            }
            if(DkLv3.intance != null){
                DkLv3.intance.Decrement();
            }
            if(DkLv4.intance != null){
                DkLv4.intance.Decrement();
            }
            if(DkLv5.intance != null){
                DkLv5.intance.Decrement();
            }
            if(DkLv6.intance != null){
                DkLv6.intance.Decrement();
            }
            if(DkLv7.intance != null){
                DkLv7.intance.Decrement();
            }
            Destroy(gameObject);
        }
    }

}
