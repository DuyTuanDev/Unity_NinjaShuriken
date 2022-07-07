using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ClickButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject btn2;
    public GameObject btn3;
    public GameObject btn4;
    public GameObject btn5;
    public GameObject btn6;
    public GameObject btn7;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("LvBtn") >= 2){
            btn2.SetActive(true);
        }   
        if(PlayerPrefs.GetInt("LvBtn") >= 3){
            btn3.SetActive(true);
        }
        if(PlayerPrefs.GetInt("LvBtn") >= 4){
            btn4.SetActive(true);
        }
        if(PlayerPrefs.GetInt("LvBtn") >= 5){
            btn5.SetActive(true);
        }
        if(PlayerPrefs.GetInt("LvBtn") >= 6){
            btn6.SetActive(true);
        }
        if(PlayerPrefs.GetInt("LvBtn") >= 7){
            btn7.SetActive(true);
        }
    }
    public void BackMenu(){
        SceneManager.LoadScene("Menu");
        
    }
    public void lv1(){
        SceneManager.LoadScene("Lv1");
        PlayerPrefs.SetInt("Diem", 0);
    }
    public void lv2(){
        SceneManager.LoadScene("Lv2");
    }
    public void lv3(){
        SceneManager.LoadScene("Lv3");
    }
    public void lv4(){
        SceneManager.LoadScene("Lv4");
    }
    public void lv5(){
        SceneManager.LoadScene("Lv5");
    }
    public void lv6(){
        SceneManager.LoadScene("Lv6");
    }
    public void lv7(){
        SceneManager.LoadScene("Lv7");
    }

}
