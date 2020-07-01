using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public List<Playable> selectedUnitsList;
    public Vector3 selectboxClickPos;
    public Vector3 selectboxReleasePos;

    private void Awake()
    {
        selectedUnitsList = new List<Playable>();   
    }

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit selectHitInfo = new RaycastHit();
            bool selectHit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out selectHitInfo);

            if (selectHit)
            {
                if (selectHitInfo.collider != null)
                {
                    selectboxClickPos = selectHitInfo.transform.position;
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
                    selectedUnitsList.Add(unit);
                }
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit orderHitInfo = new RaycastHit();
            var orderRay = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(orderRay, out orderHitInfo))
            {
                if (orderHitInfo.collider != null)
                {
                    Debug.Log(orderHitInfo.point);
                }
            }
        }
    }
}
