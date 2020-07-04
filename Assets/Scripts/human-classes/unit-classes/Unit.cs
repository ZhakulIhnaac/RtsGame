using UnityEngine;
using UnityEngine.AI;

public class Unit : Playable
{
    public int populationCost;
    protected RaycastHit hitInfo = new RaycastHit();
    
    void Start()
    {
        
    }

    void Update()
    {

    }

    protected void Stop()
    {
        navMeshAgent.isStopped = true;
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
}
