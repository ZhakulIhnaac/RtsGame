using Enums;
using IUnits;
using System.Collections.Generic;
using UnityEngine;

public class Unit : Playable, IUnit
{
    public int populationCost;
    protected RaycastHit hitInfo = new RaycastHit();
    protected List<Vector3> destinations = new List<Vector3>();
    private bool followTheEnemy = true;
    protected EUnitStatus unitStatus;

    void Start()
    {
        unitStatus = EUnitStatus.Idle;
    }

    void Update()
    {
        switch (unitStatus)
        {
            case EUnitStatus.Idle:
                break;
            case EUnitStatus.Holding:
                break;
            case EUnitStatus.Patrolling:
                break;
            case EUnitStatus.Agressive:
                break;
            case EUnitStatus.Moving:
                if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
                {
                    Stop();
                }
                break;
            default:
                break;
        }
    }

    public void Stop()
    {
        navMeshAgent.isStopped = true;
        unitStatus = EUnitStatus.Idle;
        anim.SetBool("isMoving", false);
    }

    public void Move()
    {
        anim.SetBool("isMoving", true);
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            navMeshAgent.destination = hitInfo.point;
        }
    }

    public void Patrol(Vector3 startPoint, Vector3 endPoint)
    {
        destinations.Clear();
        destinations.Add(startPoint);
        destinations.Add(endPoint);
    }

    public void HoldPosition()
    {
        followTheEnemy = false;
    }
}