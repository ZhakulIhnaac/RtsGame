using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    GameObject mainGameObject;
    // Start is called before the first frame update
    void Start()
    {
        mainGameObject = GameObject.Find("MainGame");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainGameObject.GetComponent<MainGame>().selectedPlayableList.Clear();

            RaycastHit selectHitInfo = new RaycastHit();
            bool selectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out selectHitInfo);

            if (selectHit)
            {
                if (selectHitInfo.collider.GetComponent<Playable>() != null)
                {
                    if (selectHitInfo.collider.GetComponent<Unit>() != null)
                    {
                        mainGameObject.GetComponent<MainGame>().selectedPlayableList.Add(selectHitInfo.collider.gameObject);
                        selectHitInfo.collider.GetComponent<Unit>().Selected();
                    }
                    else if (selectHitInfo.collider.GetComponent<ProductionBuilding>() != null)
                    {
                        mainGameObject.GetComponent<MainGame>().selectedPlayableList.Add(selectHitInfo.collider.gameObject);
                        selectHitInfo.collider.GetComponent<ProductionBuilding>().Selected();
                        GameObject.Find("Button_1").GetComponent<Button>().Clicked();
                    }
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            RaycastHit selectHitInfo = new RaycastHit();
            bool selectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out selectHitInfo);

            if (selectHit)
            {
                if (selectHitInfo.collider != null)
                {
                    mainGameObject.GetComponent<MainGame>().selectboxReleasePos = selectHitInfo.transform.position;
                }
            }

            Collider[] selectedList = Physics.OverlapBox(mainGameObject.GetComponent<MainGame>().selectboxClickPos - new Vector3(400, 400, 400), mainGameObject.GetComponent<MainGame>().selectboxReleasePos + new Vector3(400, 400, 400));

            mainGameObject.GetComponent<MainGame>().selectedPlayableList.Clear();

            foreach (var item in selectedList)
            {
                if (item.GetComponent<Unit>() != null)
                {
                    mainGameObject.GetComponent<MainGame>().selectedPlayableList.Add(item.gameObject);
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (mainGameObject.GetComponent<MainGame>().selectedPlayableList.Count > 0)
            {
                if (mainGameObject.GetComponent<MainGame>().selectedPlayableList[0].GetComponent<Unit>() != null) // If the unit class is selected.
                {
                    foreach (var unit in mainGameObject.GetComponent<MainGame>().selectedPlayableList)
                    {
                        unit.GetComponent<Unit>().Move();
                    }
                }
                else
                {
                    // Set Flag for production buildings
                }
            }
        }
    }
}
