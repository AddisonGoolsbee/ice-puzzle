using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCamera : MonoBehaviour
{
	public float newLocX = 0f;
    public float newLocY = 0f;


    void OnTriggerEnter2D(Collider2D other) {
    	if (other.tag == "Player"){
            Camera.main.transform.position = new Vector3(newLocX, newLocY, -10);
        }
    }

}
