using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DkMan1 : MonoBehaviour
{
    public static DkMan1 intance;
    public string SceneLv;
    //Animator ani;
    BoxCollider2D box;
    [HideInInspector] public int collectable;
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
    IEnumerator OpenCua(){
        ani.SetBool("Mo", true);
        yield return new WaitForSeconds(.7f);
        box.isTrigger = true;
    }
    //Dieu kien mo cua
    public void Decrement(){
        collectable--;
        if(collectable == 0){
            StartCoroutine(OpenCua());
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            SceneManager.LoadScene(SceneLv);
            PlayerPrefs.SetString("ManDangChoi", SceneLv);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
