using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other){
    	if (other.tag=="Player"){
    		transform.GetComponent<Renderer>().material.color = Color.green;
			
			GameObject[] gameObjectArray = GameObject.FindGameObjectsWithTag ("Changeable");
			
			foreach(GameObject change in gameObjectArray){
				change.SetActive(!change.activeInHierarchy);
				Debug.Log(change.activeInHierarchy.ToString());
			}
		}
    }
}
