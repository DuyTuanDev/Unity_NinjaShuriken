using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lv6MoBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        
    }
    BoxCollider2D box;
    // Update is called once per frame
    void Update()
    {
        box.isTrigger = true;
    }
    public string SceneLv;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            SceneManager.LoadScene(SceneLv);
            PlayerPrefs.SetString("ManDangChoi", SceneLv);
            PlayerPrefs.SetInt("LvBtn", 7);
        }
    }
}
