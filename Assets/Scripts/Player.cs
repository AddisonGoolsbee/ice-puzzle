using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float speed;
	public bool sliding = false;
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        checkIfStill();
        readInput();
        
    }

    void readInput(){
        if(!sliding){
            if(Input.GetKeyDown(KeyCode.UpArrow)){
                rb.velocity = new Vector2(0, speed);
            } else if(Input.GetKeyDown(KeyCode.DownArrow)){
                rb.velocity = new Vector2(0, -speed);
            }else if(Input.GetKeyDown(KeyCode.RightArrow)){
                rb.velocity = new Vector2(speed, 0);
            }else if(Input.GetKeyDown(KeyCode.LeftArrow)){
                rb.velocity = new Vector2(-speed, 0);
            }
        }
    }

    void checkIfStill(){
        sliding = !(rb.velocity == new Vector2(0,0));
    }

}
