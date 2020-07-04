
using UnityEngine;

namespace IUnits
{
    public interface IUnit
    {
        public void Move();
        public void Stop();
        public void Patrol(Vector3 startPoint, Vector3 endPoint);
        public void HoldPosition();
    }
}
