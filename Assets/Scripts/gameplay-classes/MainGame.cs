using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public List<GameObject> selectedUnitsList;
    public Vector3 selectboxClickPos;
    public Vector3 selectboxReleasePos;

    //private void Awake()
    //{
        
    //}

    void Start()
    {
        selectedUnitsList = new List<GameObject>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit selectHitInfo = new RaycastHit();
            bool selectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out selectHitInfo);
            selectedUnitsList.Clear();

            if (selectHit)
            {
                if (selectHitInfo.collider.GetComponent<Playable>() != null)
                {
                    selectedUnitsList.Add(selectHitInfo.collider.gameObject);
                    Debug.Log(selectedUnitsList.Count);
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
                    selectboxReleasePos = selectHitInfo.transform.position;
                }
            }

            Collider[] selectedList = Physics.OverlapBox(selectboxClickPos - new Vector3(400, 400, 400), selectboxReleasePos + new Vector3(400, 400, 400));

            selectedUnitsList.Clear();

            foreach (var item in selectedList)
            {
                Unit unit = item.GetComponent<Unit>();
                if (unit != null)
                {
                    selectedUnitsList.Add(item.gameObject);
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (selectedUnitsList.Count > 0)
            {
                if (selectedUnitsList[0].GetComponent<Unit>() != null) // If the unit class is selected.
                {
                    foreach (var unit in selectedUnitsList)
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
