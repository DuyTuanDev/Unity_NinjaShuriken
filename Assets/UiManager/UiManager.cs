using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    static public UiManager instance;
    public Text SoHp;
    public Text SoBinhHp;
    public Text PauseGameSetText;

    
    public void SetScoreText(string txt){
        if(SoHp){
            SoHp.text = txt;
        }
    }
    public void BinhHp(string txt){
        if(SoBinhHp){
            SoBinhHp.text = txt;
        }
    }
    public void PauseGame(string txt){
        if(PauseGameSetText){
            PauseGameSetText.text = txt;
        }
    }
    void Start()
    {
        UiManager.instance = this;
        // tìm kiếm đối tượng UI là text
        SoHp = GameObject.Find("SoHp").GetComponent<Text>();
        SoBinhHp = GameObject.Find("BinhHp").GetComponent<Text>();
        // PauseGameSetText = GameObject.Find("TamDung").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
