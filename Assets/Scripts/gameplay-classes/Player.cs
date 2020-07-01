using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    protected int ownedCrystals;
    protected int solarPower;
    protected int population;
    protected string playerName;

    protected void KillPlayableObject ()
    {
        Destroy(this);
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
