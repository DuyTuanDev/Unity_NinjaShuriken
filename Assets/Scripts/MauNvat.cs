using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MauNvat : MonoBehaviour
{
    // Start is called before the first frame update
    public float maxHp;
    public float current;
    //public GameObject bloodEffect;

    // Hien hp
    static public MauNvat instance;
    public Slider playerHp;
    GameController m_gc;

    void Start()
    {
        MauNvat.instance = this;
        current = PlayerPrefs.GetFloat("hp");
        playerHp.maxValue = maxHp; // gan gia tri
        
        m_gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    public int SoLuongBinhMau;




    void Update()
    {
        SoLuongBinhMau = PlayerPrefs.GetInt("slhp");
        UiManager.instance.BinhHp(""+ SoLuongBinhMau);

        playerHp.value = PlayerPrefs.GetFloat("hp");
        playerHp.value = current;
        // hien mau
        UiManager.instance.SetScoreText(""+current);
    }
    public void addDamage( float dame){
        EfManage.instance.SpawnVFX("mau", transform.position, transform.rotation);
        if(dame <= 0 ) 
            return;
        current -= dame;
        // tru Hp
        playerHp.value = current;
        PlayerPrefs.SetFloat("hp", current);
        if(current <= 0) makeDead();
    }
    void makeDead(){
        UiManager.instance.PauseGame("GameOver");
        //Instantiate(/*hieuungchet*/ bloodEffect, transform.position, transform.rotation);
        PlayerPrefs.SetFloat("hp", maxHp);
        UiManager.instance.SetScoreText("0");
        //SceneManager.LoadScene("Menu");
        Destroy(gameObject);
        m_gc.PlayerDied();
        //Destroy(gameObject);
    }
    //
    // Tao chuc nang hoi mau khi an mau
    public void addHp(float hearltAmount){
        current += hearltAmount;
        if(current > maxHp){
            current = maxHp;
        }
        playerHp.value = current;
        PlayerPrefs.SetFloat("hp", current);
        
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "chet"){
            PlayerPrefs.SetFloat("hp", maxHp);
            UiManager.instance.PauseGame("GameOver");
            m_gc.PlayerDied();
        }
        if(other.gameObject.tag == "BinhMau"){
            SoLuongBinhMau++;
            PlayerPrefs.SetInt("slhp", SoLuongBinhMau);
        }
    }
}
