using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TuDongDiCHuyenCoDiemDung : MonoBehaviour
{
    [SerializeField]
    Transform start, end;
    bool collision;
    public float speed;
    Rigidbody2D myBody;
    private void Awake() {
        myBody = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // boss tu di chuyen trai phai
    void Change(){
        collision = Physics2D.Linecast(start.position, end.position, 1 <<LayerMask.NameToLayer("Ground"));
        Debug.DrawLine(start.position, end.position, Color.green);
        if(!collision){
            Vector3 temp = transform.localScale;
            if(temp.x == 2.7725f){
                temp.x =-2.7725f;
            }
            else{
                temp.x = 2.7725f;
            }
            transform.localScale = temp;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        Change();
    }
    void Move(){
        myBody.velocity = new Vector2(transform.localScale.x,0) * speed;
    }
}
