using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ZombieAI : MonoBehaviour {

    GameObject player;
    NavMeshAgent agent;


	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = GetComponent<NavMeshAgent>();
        agent.isStopped = false;
    }

    void Update() {        

        if (player != null)
        {
            agent.destination = player.transform.position;
        }
        else {            
            agent.isStopped = true;
        }
    }
}
