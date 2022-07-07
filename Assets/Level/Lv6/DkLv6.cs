using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DkLv6 : MonoBehaviour
{
    public static DkLv6 intance;
    
    //Animator ani;
    BoxCollider2D box;
    // [HideInInspector] public 
    public int collectable;
    Animator ani ;
    private void Awake() {
        MakeInstance();
        ani = GetComponent<Animator>();
        box = GetComponent<BoxCollider2D>();
    }
    void MakeInstance(){
        if(intance == null){
            intance = this;
        
        }
    }
    public GameObject boxcl;
    IEnumerator OpenCua(){
        boxcl.SetActive(true);
        ani.SetBool("Mo", true);
        yield return new WaitForSeconds(.7f);
        
    }
    //Dieu kien mo cua
    public void Decrement(){
        collectable--;
        if(collectable == 0){
            StartCoroutine(OpenCua());
        }
    }

    void Start()
    {
        boxcl.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
