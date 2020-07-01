﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionBuilding : Playable
{

    protected List<Unit> productables;
    protected List<Unit> productionList;
    protected int productionLimit;
    protected Waypoint waypoint;

    protected void AddProduction(Unit unit)
    {
        if (productionList.Count < productionLimit)
        {
            productionList.Add(unit);
        }
    }

    protected void SetWaypoint(Vector3 position)
    {

    }

    protected void CancelProduction()
    {
        if (productionList.Count > 0)
        {
            productionList.RemoveAt(productionList.Count - 1);
        }
    }

    protected void Spawn()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}