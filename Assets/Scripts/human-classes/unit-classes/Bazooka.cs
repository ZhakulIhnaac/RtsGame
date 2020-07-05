using Enums;
using UnityEngine;
using UnityEngine.AI;

public class Bazooka : Attacker
{

    void Start()
    {
        anim = GetComponent<Animator>();
        armor = 10.0f;
        attackingRange = 5f;
        buildTime = 20;
        crystalRequirement = 200;
        definition = "Bazooka Trooper is specialized with sending the target to the eternity, piece by piece.";
        health = 200.0f;
        hitPoint = 20f;
        navMeshAgent = GetComponent<NavMeshAgent>();
        playableName = "Bazooka Trooper";
        populationCost = 2;
        sightRange = 10.0f;
        solarPowerRequirement = 200;
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
            case EUnitStatus.InAction:
                if ((target.transform.position - transform.position).magnitude > attackingRange)
                {
                    navMeshAgent.destination = target.transform.position;
                }
                else
                {
                    anim.SetBool("isMoving", false);
                    anim.SetBool("isInAction", true);
                    ShootToKill(target);
                }
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

}
