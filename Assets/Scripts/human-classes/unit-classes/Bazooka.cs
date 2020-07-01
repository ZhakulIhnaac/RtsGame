using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        selected = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckActiveOrder();

        if (Input.GetMouseButtonDown(1))
        {
            if (!Input.GetKey(KeyCode.LeftShift))
            {
                orderList.Clear();
                activeOrder = null;
            }

            RaycastHit orderHitInfo = new RaycastHit();
            var orderRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(orderRay, out orderHitInfo))
            {
                if (orderHitInfo.collider != null)
                {
                    Move(new Vector3(orderHitInfo.point.x, 0, orderHitInfo.point.z));
                    anim.SetBool("moving", true);
                }
            }
        }
    }
}
