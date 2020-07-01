using UnityEngine;
using UnityEngine.AI;

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