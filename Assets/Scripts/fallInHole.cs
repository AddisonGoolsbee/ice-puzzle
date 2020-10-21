using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fallInHole : MonoBehaviour
{
    public string nextLevel;

    void OnTriggerEnter2D(Collider2D other) {
    	if (other.tag == "Player"){
    		//Scene sceneToLoad = SceneManager.GetSceneByName(nextLevel);
    		SceneManager.LoadScene(nextLevel);
    		//SceneManager.MoveGameObjectToScene(other.gameObject, sceneToLoad);
    	}
    }
}
