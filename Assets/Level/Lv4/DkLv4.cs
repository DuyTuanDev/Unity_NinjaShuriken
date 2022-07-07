using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DkLv4 : MonoBehaviour
{
    public static DkLv4 intance;
    public string SceneLv;
    //Animator ani;
    BoxCollider2D box;
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
            PlayerPrefs.SetInt("LvBtn", 5);
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        
    }
}
