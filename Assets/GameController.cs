using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    MauNvat hp;
    int m_score;
    void Start()
    {
        hp = FindObjectOfType<MauNvat>();
        m_score = PlayerPrefs.GetInt("Diem");
        SetScoreText("Score: " + m_score);
    }
    public Text scoreText;
    public Text scoreSum;
    public void SetScoreText(string txt){
        if(scoreText){
            scoreText.text = txt;
        }
        if(scoreSum){
            scoreSum.text = txt;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(MauNvat.instance.current > MauNvat.instance.maxHp)
        {
            MauNvat.instance.current = MauNvat.instance.maxHp;
        }
        //btnHp = GameObject.Find("hp").GetComponent<Button>();
    }
    //public Button btnHp;
    public void UseHp(){
        
        
        int sl = PlayerPrefs.GetInt("slhp");
        if(sl > 0){
            if(MauNvat.instance.current <= MauNvat.instance.maxHp){
            MauNvat.instance.current += 20;
            }
            sl--;   
            PlayerPrefs.SetFloat("hp", MauNvat.instance.current);
        }
        
        PlayerPrefs.SetInt("slhp", sl);
    }
    public GameObject btnTiepTuc;
    public GameObject pausePanel;
    public void PauseGame(){
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        SetScoreText("Score: " + m_score);
    }

    public void TiepTuc(){
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }
    public void PlayerDied(){
        Debug.Log("Pannel");
        
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
        btnTiepTuc.SetActive(false);
        SetScoreText("Score: " + m_score);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv2(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv2");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv1(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv1");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv3(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv3");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void QuidGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv4(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv4");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv5(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv5");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv6(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv6");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }
    public void ReplayLv7(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("lv7");
        btnTiepTuc.SetActive(true);
        PlayerPrefs.SetFloat("hp", hp.maxHp);
        PlayerPrefs.SetInt("Diem", 0);
        PlayerPrefs.SetInt("dung", 0);
        PlayerPrefs.SetInt("slhp", 0);
    }

    // Diem nguoi choi!
    public void SetScore(int value){
        m_score = value;
    }
    public int GetScore(){
        return m_score;
    }
    public void ScoreIncrement(){
        m_score++;
        SetScoreText("Score: " + m_score);
        PlayerPrefs.SetInt("Diem", m_score);
    }


}
