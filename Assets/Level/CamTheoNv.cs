using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamTheoNv : MonoBehaviour
{
    Transform player;
    Transform playery;

    public float minX, maxX;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
        playery = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null){
            Vector3 temp = transform.position;
            temp.x = player.position.x;

            if(temp.x < minX){
                temp.x = minX;
            }

            if(temp.x > maxX){
                temp.x = maxX;
            }

            transform.position = temp;
        }
        if(playery != null){
            Vector3 tempy = transform.position;
            tempy.y = playery.position.y;

            if(tempy.y < minY){
                tempy.y = minY;
            }

            if(tempy.y > maxY){
                tempy.y = maxY;
            }

            transform.position = tempy;
        }
    }
}
