using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform taget; // diem cam theo doi
    public float smon; // di chuyen cam muot ma
    Vector3 offset;
    float lowY;
    void Start()
    {
        offset = transform.position - taget.position; // vij tri cam - vij tri nv
        lowY = transform.position.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCamPos = taget.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smon * Time.deltaTime);
        if(transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
    // khoa cam tren
        //if(transform.position.y > lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
    }
}
