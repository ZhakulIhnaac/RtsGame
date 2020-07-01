using UnityEngine;
using UnityEngine.AI;

public class Bazooka : Attacker
{
    protected NavMeshAgent navMeshAgent;
    protected RaycastHit hitInfo = new RaycastHit();
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
        selected = false;
        anim = GetComponent<Animator>();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) && !Input.GetKey(KeyCode.LeftShift))
        {
            anim.SetBool("isMoving",true);
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
            {
                navMeshAgent.destination = hitInfo.point;
            }
        }
    }
}
