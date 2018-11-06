using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	
	void Start () {
        Destroy(gameObject, 5f);
	}

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Zombie")){
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }      
}
