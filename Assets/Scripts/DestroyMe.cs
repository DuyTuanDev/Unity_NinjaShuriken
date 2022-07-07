using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    // Start is called before the first frame update    public float TimeTonTai;
    public float TimeTonTai;
    void Start()
    {
        Destroy(gameObject, TimeTonTai);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
