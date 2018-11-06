using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveSpawner : MonoBehaviour {

    public GameObject zombie;
    public GameObject spawnPoint;
    public float spawnrate = 10.0f;
    float lastSpawnTime;

	// Use this for initialization
	void Start () {
        lastSpawnTime = Time.time;

    }
	
	// Update is called once per frame
	void Update () {
        if (lastSpawnTime < Time.time) {
            lastSpawnTime = Time.time + spawnrate;
            Instantiate(zombie, spawnPoint.transform.position, Quaternion.identity);
        }
	}
}
