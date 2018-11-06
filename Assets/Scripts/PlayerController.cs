using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public Camera mainCamera;
    public Plane map;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {        

        LookAtCameraMousePointer();
    }

    void FixedUpdate() {

        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        moveDirection = moveDirection.normalized;
        rb.MovePosition(rb.position + (moveDirection * Time.deltaTime * moveSpeed));

    }

    void LookAtCameraMousePointer() {        

        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);
        float rayDistance;

        if (groundPlane.Raycast(ray, out rayDistance)) {
            Vector3 point = ray.GetPoint(rayDistance);
            Debug.DrawLine(ray.origin, point);
            transform.LookAt(new Vector3(point.x,transform.position.y,point.z));
        }  
    }
}
