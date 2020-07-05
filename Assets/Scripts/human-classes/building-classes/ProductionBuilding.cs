using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductionBuilding : Playable
{
    public List<GameObject> produceables;
    protected List<GameObject> productionList;
    protected GameObject currentProduction;
    protected int productionLimit;
    protected Waypoint waypoint;
    protected bool isProducing;
    protected int productionTimePassed;

    public void AddProduction(GameObject unit)
    {
        if (productionList.Count < productionLimit)
        {
            Debug.Log("isProducing: " + isProducing);
            Debug.Log("AddedToProduction");
            if (unit.GetComponent<Unit>().populationCost + /*unit.GetComponent<Playable>().owner.populationCount*/ 4 <= GameObject.Find("MainGame").GetComponent<MainGame>().populationLimit)
            {
                productionList.Add(unit);
                Debug.Log("ProductionList: " + productionList);
                isProducing = !isProducing;
                StartProduction();
            }
            else
            {
                // TODO: GiveWarning(string warning) adında, ekrana warning veren bir metot oluştur ve içerisine popülasyon uyarısı gönder.;
            }
        }
        else
        {
            // TODO: GiveWarning(string warning) adında, ekrana warning veren bir metot oluştur ve içerisine popülasyon uyarısı gönder.;
        }
    }

    protected void SetWaypoint(Vector3 position)
    {
        // TODO: On rightclick, a flag will be placed on the clicked position on the navMesh.
    }

    protected void CancelProduction()
    {
        if (productionList.Count > 0)
        {
            productionList.RemoveAt(productionList.Count - 1);
        }
    }

    protected void StartProduction()
    {
        currentProduction = productionList[0];
        Debug.Log("CurrentProduction: " + currentProduction);
        StartCoroutine(SpawnUnit());
    }

    protected void FinishProduction()
    {
        productionList.RemoveAt(0);
        Debug.Log("ProductionListAfterRemove: " + productionList);

        if (productionList.Count > 0)
        {
            StartProduction();
        }
        else
        {
            isProducing = !isProducing;
            Debug.Log("isProducing: " + isProducing);
        }
    }

    IEnumerator SpawnUnit()
    {
        Debug.Log("ProductionBeginning: " + Time.time);
        yield return new WaitForSeconds(currentProduction.GetComponent<Playable>().buildTime);
        Debug.Log("ProductionEnd: " + Time.time);
        Instantiate(currentProduction, transform.position + new Vector3(10,0,-10), Quaternion.identity);
        Debug.Log("Instantiated");
        FinishProduction();
    }

}
