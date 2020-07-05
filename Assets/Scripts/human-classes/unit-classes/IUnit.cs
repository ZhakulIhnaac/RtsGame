
using UnityEngine;

namespace IUnits
{
    public interface IUnit
    {
        void Move();
        void Stop();
        void Patrol(Vector3 startPoint, Vector3 endPoint);
        void HoldPosition();
    }
}
