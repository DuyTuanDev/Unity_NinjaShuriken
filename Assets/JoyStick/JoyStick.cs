using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JoyStick : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{   
    PlayerController player;
    private void Awake() {
        player = GameObject.Find("Player").GetComponent<PlayerController>();    
    }
    public void OnPointerDown(PointerEventData data){
        if(gameObject.name == "Left"){
           player.SetMoveLeft(true);
            Debug.Log("Left");
        }
        else if(gameObject.name == "Right"){
            player.SetMoveLeft(false);
            Debug.Log("Right");
        }
        else if (gameObject.name == "Jump"){
            player.SetNhay(true);
            Debug.Log("Jump");
        }
        else if (gameObject.name == "Attack"){
            player.SetAttack(true);
            Debug.Log("Attack");
        }
    }
    public void OnPointerUp(PointerEventData data){
        player.StopMoving();
    }
}
