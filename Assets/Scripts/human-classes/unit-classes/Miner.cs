using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Miner : Unit
{
    protected int carryAmount;
    protected GameObject[] buildingOptions;

    protected void Mine(Crystal crystal)
    {
 
    }

    protected void BuildOrder(GameObject building)
    {
        unitStatus = EUnitStatus.Moving;
        navMeshAgent.destination = building.transform.position;
    }

    protected void StartBuilding()
    {
        unitStatus = EUnitStatus.InAction;

    }

    void Start()
    {

    }

    void Update()
    {

    }
}
