using UnityEngine;

public class Button : MonoBehaviour
{
    GameObject mainGameObject;

    private void Start()
    {
        mainGameObject = GameObject.Find("MainGame");
    }

    public void Clicked()
    {
        var a = mainGameObject.GetComponent<MainGame>().selectedPlayableList[0];
        a.GetComponent<ProductionBuilding>().AddProduction(a.GetComponent<Barracks>().produceables[0]);
    }

    public void Refresh()
    {
        //var c = mainGameObject.GetComponent<MainGame>().selectedPlayableList.Count;
    }
}
