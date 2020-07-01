using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeBuilding : Playable
{

    protected List<Upgrade> upgrades;
    protected List<Upgrade> upgradeList;
    protected int upgradeLimit;

    protected void AddUpgrade(Upgrade upgrade)
    {
        if (upgradeList.Count < upgradeLimit)
        {
            upgradeList.Add(upgrade);
        }
    }

    protected void CancelUpgrade()
    {
        if (upgradeList.Count > 0)
        {
            upgradeList.RemoveAt(upgradeList.Count - 1);
        }
    }

    protected void Spawn()
    {

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
