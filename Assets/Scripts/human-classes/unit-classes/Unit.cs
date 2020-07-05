using Enums;
using IUnits;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Playable, IUnit
{
    public int populationCost;
    protected RaycastHit hitInfo = new RaycastHit();
    protected List<Vector3> destinations = new List<Vector3>();
    protected EUnitStatus unitStatus;

    public void Stop()
    {
        unitStatus = EUnitStatus.Idle;
        navMeshAgent.isStopped = true;
        anim.SetBool("isMoving", false);
    }

    public void Move()
    {
        unitStatus = EUnitStatus.Moving;
        anim.SetBool("isMoving", true);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            navMeshAgent.destination = hitInfo.point;
        }
    }

    public void Patrol(Vector3 startPoint, Vector3 endPoint)
    {
        unitStatus = EUnitStatus.Patrolling;
        destinations.Clear();
        destinations.Add(startPoint);
        destinations.Add(endPoint);
    }

    public void HoldPosition()
    {
        unitStatus = EUnitStatus.Holding;
    }
}