using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{

    GameObject mainGameObject;
    GameObject focusCamera;

    void Start()
    {
        mainGameObject = GameObject.Find("MainGame");
        focusCamera = GameObject.Find("FocusCamera");
    }

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

                    mainGameObject.GetComponent<MainGame>().selectedPlayable = selectHitInfo.collider.gameObject;
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

        if (mainGameObject.GetComponent<MainGame>().selectedPlayable != null) // Optimize edilecek, bu kadar fazla çağırma yapma hoj değil.
        {
            focusCamera.transform.LookAt(mainGameObject.GetComponent<MainGame>().selectedPlayable.transform);
            focusCamera.transform.position = mainGameObject.GetComponent<MainGame>().selectedPlayable.transform.position + new Vector3(0, mainGameObject.GetComponent<MainGame>().selectedPlayable.transform.lossyScale.y * 2, 0) + mainGameObject.GetComponent<MainGame>().selectedPlayable.transform.forward;
        }
        else
        {
            focusCamera.transform.position = focusCamera.GetComponent<FocusCamera>().initialPosition;
            focusCamera.transform.rotation = focusCamera.GetComponent<FocusCamera>().initialRotation;
        }
    }
}
