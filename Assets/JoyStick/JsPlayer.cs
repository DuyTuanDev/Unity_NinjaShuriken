using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsPlayer : MonoBehaviour
{
    Transform tranphom;
    protected Rigidbody2D rmybody;
    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    void Start()
    {
        this.rmybody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() {
        MoveButton();
    }
    void MoveButton(){
        if(moveLeft)
        {
            // this.rmybody.MovePosition(this.rmybody.position + this.velocity * Time.fixedDeltaTime);
            // velocity.x = -1 * speed;
            //PlayerController.intances.
            
        }
        if(moveRight){
            // this.rmybody.MovePosition(this.rmybody.position + this.velocity * Time.fixedDeltaTime);
            // velocity.x = 1 * speed;
        }
        if(jump){
            // this.rmybody.MovePosition(this.rmybody.position + this.velocity * Time.fixedDeltaTime);
            // velocity.y = 1 * speed;
        }
        // this.pressHorizontal = Input.GetAxis("Horizontal");
        // this.pressVertical = Input.GetAxis("Vertical");
        // if(Input.GetKey(KeyCode.A)){
        //     Debug.Log("Phim A");
            
        // }
    }



    public void SetMoveLeft( bool moveLeft){
        this.moveLeft = moveLeft;
        this.moveRight = !moveLeft;
        //this.jump = !moveRight;
    }
    // public void SetJump(bool jump){
    //     this.jump = jump;
    // }
    // public void OnPointerDown(PointerEventData data){
    //     if(gameObject.name == "Left"){
    //         SetMoveLeft(true);
    //         Debug.Log("Left");
    //     }
    //     else{
    //         SetMoveLeft(false);
    //         Debug.Log("Right");
    //     }
    // }
    // public void OnPointerUp(PointerEventData data){
    //     StopMoving();
    // }
    bool moveLeft, moveRight, jump;
    public void StopMoving(){
        this.moveLeft = false;
        this.moveRight = false;
        //this.jump = true;
    }
}
