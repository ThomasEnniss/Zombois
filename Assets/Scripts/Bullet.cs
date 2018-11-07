using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour, IDamageAble {
	
	void Start () {
        Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Damage(collision.gameObject);
    }

    public void Damage(GameObject other)
    {
        Die();       
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
