using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    internal bool interactable;
    //public AudioSource aus;
    public GameObject BtnPlay;
    public GameObject BtnContinue;
    public GameObject BtnExit;
    public GameObject NutRight2;

    public GameObject NutRight1;
    public GameObject Left1;

    public GameObject Left2;
    MauNvat hp;
    //public AudioClip loseSound;
    // Start is called before the first frame update
    void Start()
    {
        hp = FindObjectOfType<MauNvat>();
        //aus.PlayOneShot(loseSound);
    }

    // Update is called once per frame
    // int SoLuongBinhMau = 0;
    void Update()
    {
        
    }
    public void PlayGame(){
        PlayerPrefs.SetInt("LvBtn", 1);
        SceneManager.LoadScene("Level");
        PlayerPrefs.SetString("ManDangChoi", "Lv1");
        PlayerPrefs.SetFloat("hp", 200);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("slhp", 0);
        PlayerPrefs.SetInt("dung", 0);
    }
    public void Continue(){
        SceneManager.LoadScene(PlayerPrefs.GetString("ManDangChoi"));
        Debug.Log(":"+PlayerPrefs.GetString("ManDangChoi")+":");
        
    }
    public void BtnNewPlayLeft(){
        BtnPlay.SetActive(true);
        BtnContinue.SetActive(false);
        NutRight2.SetActive(false);
        NutRight1.SetActive(true);
        Left1.SetActive(false);
    }
    public void BtnContinueRight(){
        NutRight1.SetActive(false);
        BtnPlay.SetActive(false);
        BtnContinue.SetActive(true);
        NutRight2.SetActive(true);
        Left1.SetActive(true);

        
    }
    public void HienNutExit(){
        BtnContinue.SetActive(false);
        BtnExit.SetActive(true);
        Left1.SetActive(false);
        Left2.SetActive(true);
        NutRight2.SetActive(false);
    }
    public void HienNutPlay(){
        BtnContinue.SetActive(true);
        BtnExit.SetActive(false);
        Left2.SetActive(false);
        Left1.SetActive(true);
        NutRight2.SetActive(true);
    }
    public void AnVaoExit(){
        PlayerPrefs.Save();
        Application.Quit();
    }
}
