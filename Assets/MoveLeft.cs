using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 30;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,1)*speed;
        }else if(Input.GetKey(KeyCode.S)){
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,-1)*speed;
        }else{
            GetComponent<Rigidbody2D>().velocity = new Vector2(0,0)*speed;
        }
    }
}
