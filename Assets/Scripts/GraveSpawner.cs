using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveSpawner : MonoBehaviour {
  
    public GameObject zombie;
    GameObject[] graves;
    public GameObject scorer;
    public float spawnrate = 10.0f;
    float lastSpawnTime;
    int numberOfGraves = 0;

    // Use this for initialization
    void Start () {
        lastSpawnTime = Time.time;
        graves = GameObject.FindGameObjectsWithTag("Grave");
        numberOfGraves = graves.Length;
        Debug.Log("Number Of Graves"+ numberOfGraves);
    }
	
	// Update is called once per frame
	void Update () {

        if (lastSpawnTime < Time.time) {
             
            int chosenGrave = Random.Range(0, numberOfGraves);
            Debug.Log("Zombie Spawning at Grave: " + chosenGrave);
            lastSpawnTime = Time.time + spawnrate;
            GameObject zomboi = Instantiate(zombie, graves[chosenGrave].transform.position, Quaternion.identity);

            zomboi.GetComponent<EnemyDamageable>().Dead += scorer.GetComponent<ScoreKeeper>().ZombieKilled;
        }
	}
}
