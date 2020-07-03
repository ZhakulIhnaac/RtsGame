using UnityEngine;

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
    }

    public void Move()
    {
        Debug.Log(anim);
        anim.SetBool("isMoving", true);
        Debug.Log("A2");
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("A3");
        if (Physics.Raycast(ray.origin, ray.direction, out hitInfo))
        {
            navMeshAgent.destination = hitInfo.point;
        }
    }
}
