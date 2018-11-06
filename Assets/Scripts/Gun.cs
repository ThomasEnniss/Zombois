using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bullet;
    public GameObject muzzle;
    public GameObject player;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {
            Fire();
        }
	}

    void Fire() {
        GameObject newBullet =  Instantiate(bullet, muzzle.transform.position, player.transform.localRotation);
        newBullet.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward*1500.0f);
    }
}
