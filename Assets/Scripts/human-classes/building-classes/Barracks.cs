using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Barracks : ProductionBuilding
{

    // Start is called before the first frame update
    void Start()
    {
        productionLimit = 8;
        playableName = "Barracks";
        definition = "The toughest warriors come from here, where the trainings end in two ways: Graduation or Death.";
        health = 1000;
        maxHealth = 1000;
        armor = 20;
        solarPowerRequirement = 500;
        crystalRequirement = 700;
        buildTime = 80;
        sightRange = 20;
        isProducing = false;
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        productionList = new List<GameObject>();
        currentProduction = new GameObject();
        waypoint = new Waypoint();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
