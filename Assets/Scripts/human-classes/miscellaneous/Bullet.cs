using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage;

    void OnCollisionEnter (Collision collision)
    {
        Playable collidedPlayable = collision.gameObject.GetComponent<Playable>();
        
        if (collidedPlayable != null)
        {
            if (collidedPlayable.health - damage + 0.4f * collidedPlayable.armor <= 0)
            {
                collidedPlayable.unitDestroyed();
            }
        }
    }
}
