using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : Unit
{
    public int capacity;
    public float loadRange;
    public List<Unit> unitsList;

    public void Load(Unit unit)
    {
        if (loadRange > (this.transform.position - unit.transform.position).magnitude)
        {
            unitsList.Add(unit);
            Destroy(unit);
        }
        
    }

    public void Unload()
    {
        foreach (var unit in unitsList)
        {
            Instantiate(unit, this.transform.position + new Vector3(Random.Range(-1f, -1f), Random.Range(-1f, -1f), 0), Quaternion.identity);
            unitsList.Remove(unit);
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
}
