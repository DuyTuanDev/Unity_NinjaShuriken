using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BossDieWin : MonoBehaviour
{
    // Start is called before the first frame update
    BoxCollider2D Win;
    void Start()
    {
        Win = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        WinPanel.SetActive(false);
    }

    // Update is called once per frame
    Animator animator;
    void Update()
    {
        if(HpBossLv7.instance.current <= 0){
            animator.SetBool("Mo", true);
            Win.isTrigger = true;
        }
    }
    public GameObject WinPanel;
    private void OnTriggerStay2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            WinPanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    public void QuidWinGame(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("Level");
    }
}
