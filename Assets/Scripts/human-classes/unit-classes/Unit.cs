using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : Playable
{
    public int populationCost;
    public List<MainOrder> orderList = new List<MainOrder>();
    public MainOrder activeOrder = null;
    protected NavMeshAgent navMeshAgent;
    protected RaycastHit hitInfo = new RaycastHit();

    protected void Stop()
    {
        orderList.Clear();
        activeOrder = null;
    }

    protected void Patrol(Vector3 destination)
    {
        orderList.Add(new MainOrder { patrolOrder = new PatrolOrder { destination = destination } });
    }
    protected void HoldPosition()
    {

    }

    protected void CheckActiveOrder()
    {
        if (activeOrder != null)
        {
            if (activeOrder.attackOrder != null)
            {

            }
            else if (activeOrder.healOrder != null)
            {

            }
            else if (activeOrder.mineOrder != null)
            {

            }
            else if (activeOrder.moveOrder != null)
            {
                //transform.Rotate(0, Vector3.Angle((activeOrder.moveOrder.destination - new Vector3(transform.position.x,0,transform.position.z)),transform.forward), 0);
                //transform.rotation = Quaternion.LookRotation((activeOrder.moveOrder.destination - new Vector3(transform.position.x, 0, transform.position.z)));
                
                if (Mathf.Abs((activeOrder.moveOrder.destination - transform.position).magnitude) < 1f) //Check if object is at the destination
                {
                    activeOrder = null;
                    anim.SetBool("moving", false);
                }
                else
                {
                    transform.Translate((activeOrder.moveOrder.destination - new Vector3(transform.position.x, 0, transform.position.z)) * Time.deltaTime * 1f);
                }
            }
            else if (activeOrder.patrolOrder != null)
            {

            }
        }
        else
        {
            if (orderList.Count != 0)
            {
                activeOrder = orderList[0];
                orderList.Remove(orderList[0]);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
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
