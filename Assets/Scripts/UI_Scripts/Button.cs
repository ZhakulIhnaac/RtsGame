﻿using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject mainGameObject;

    private void Start()
    {
        mainGameObject = GameObject.Find("MainGame");
    }

    public void Clicked()
    {
        var selectedPlayable = mainGameObject.GetComponent<MainGame>().selectedPlayableList[0];
        selectedPlayable.GetComponent<ProductionBuilding>().AddProduction(selectedPlayable.GetComponent<Barracks>().produceables[0]);
    }

    public void Refresh()
    {
        //var c = mainGameObject.GetComponent<MainGame>().selectedPlayableList.Count;
    }
}
