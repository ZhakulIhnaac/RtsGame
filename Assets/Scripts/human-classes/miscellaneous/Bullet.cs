using IBullets;
using UnityEngine;

public class Bullet : MonoBehaviour, IBullet
{
    protected float damage;
    protected float speed;

    public void OnCollisionEnter (Collision collision)
    {
        Playable collidedPlayable = collision.gameObject.GetComponent<Playable>();
        
        if (collidedPlayable != null)
        {
            Explosion(transform.position);
            Destroy(gameObject);

            if (collidedPlayable.health - damage + 0.4f * collidedPlayable.armor <= 0)
            {
                collidedPlayable.unitDestroyed();
            }
        }
    }

    public void FlyForward(Vector3 direction)
    {
        gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * speed);
    }

    public void Explosion(Vector3 explosionPosition)
    {
        // TODO: Instantiate an explosion gif.
    }
}
