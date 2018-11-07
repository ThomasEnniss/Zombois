using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzzleFlash : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.1f);
	}
}
