using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageAble{

    void Damage(GameObject collidedWith);

    void Die();
}
