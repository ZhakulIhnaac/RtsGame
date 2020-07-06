using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Playable : MonoBehaviour
{
    protected string playableName;
    protected string definition;
    public Player owner;
    public float health;
    public float maxHealth;
    public float armor;
    protected int solarPowerRequirement;
    protected int crystalRequirement;
    public int buildTime; // In seconds
    protected float sightRange;
    protected Animator anim;
    protected NavMeshAgent navMeshAgent;

    public IEnumerator unitDestroyed()
    {
        anim.SetBool("LolIsUDed", true);
        //TODO: Play destruction/killing sound
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }

    public void Selected()
    {
        // UI Implementation
    }
}