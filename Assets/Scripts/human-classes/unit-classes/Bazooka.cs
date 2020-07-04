using UnityEngine;
using UnityEngine.AI;

public class Bazooka : Attacker
{
    
    // Start is called before the first frame update
    void Start()
    {
        hitPoint = 20.0f;
        populationCost = 2;
        playableName = "Bazooka Trooper";
        definition = "Hit a trooper, It goes BOOM! Hit a vehicle, it goes BOOM! Everything will go BOOM someday anyway...";
        health = 50.0f;
        armor = 5.0f;
        solarPowerRequirement = 200;
        crystalRequirement = 200;
        buildTime = 20;
        sightRange = 10.0f;
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

}
