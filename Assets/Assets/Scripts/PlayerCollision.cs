
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public playercontroller movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        int life = 3;
        if (collisionInfo.collider.tag == "obsticle")
        {
            life= 1-- ;

            if (life == 0)
            {
                movement.enabled = false;
            }
        }

    }
}

