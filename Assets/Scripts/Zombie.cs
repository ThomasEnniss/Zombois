using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour {

    GameObject player;
    NavMeshAgent agent;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        agent.isStopped = false;
    }

    void Update() {
        Debug.Log("Player Position = " + player.transform.position);
        agent.destination = player.transform.position;        
    }
	
    void OnCollisionEnter(Collision other) {
        Debug.Log("Stumbled Onto Something");
        if (other.gameObject.CompareTag("Player")) {
            Destroy(other.gameObject);
        }
    }
}
