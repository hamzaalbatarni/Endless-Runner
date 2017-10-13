
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public playercontroller movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
     
        if (collisionInfo.collider.tag == "obsticle")
        {
           
                movement.enabled = false;
            }
        }

    }


