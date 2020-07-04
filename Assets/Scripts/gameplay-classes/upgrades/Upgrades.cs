using UnityEngine;

public class Upgrades
{
    void UpgradeArmors()
    {
        var onFootUnits = (GameObject[]) GameObject.FindObjectsOfType(typeof(Bazooka));
        foreach (var onFootUnit in onFootUnits)
        {
            onFootUnit.GetComponent<Unit>().maxHealth += 200;
        }
    }

    void UpgradeHealthPoints()
    {
        var onFootUnits = (GameObject[])GameObject.FindObjectsOfType(typeof(Bazooka));
        foreach (var onFootUnit in onFootUnits)
        {
            onFootUnit.GetComponent<Unit>().maxHealth += 200;
        }
    }

    void UpgradeHitpoints()
    {
        var onFootUnits = (GameObject[])GameObject.FindObjectsOfType(typeof(Bazooka));
        foreach (var onFootUnit in onFootUnits)
        {
            onFootUnit.GetComponent<Attacker>().hitPoint += 10;
        }
    }
}
