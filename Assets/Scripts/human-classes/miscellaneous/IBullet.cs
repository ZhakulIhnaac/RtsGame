
using UnityEngine;

namespace IBullets
{
    public interface IBullet
    {
        void OnCollisionEnter(Collision collision);
        void Explosion(Vector3 explosionPosition);
    }
}
