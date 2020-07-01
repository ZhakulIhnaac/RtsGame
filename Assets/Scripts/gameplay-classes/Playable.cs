using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playable : MonoBehaviour
{
    protected string playableName;
    protected string definition;
    protected Player owner;
    protected float health;
    protected float armor;
    protected int solarPowerRequirement;
    protected int crystalRequirement;
    protected int buildTime;
    protected float sightRange;
    protected bool selected;
    public Animator anim;

    public void KillPlayableObject ()
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
