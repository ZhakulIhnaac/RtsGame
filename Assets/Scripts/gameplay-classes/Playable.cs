using System.Collections;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class Playable : MonoBehaviour
{
    protected string playableName;
    protected string definition;
    protected Player owner;
    public float health;
    public float maxHealth;
    public float armor;
    protected int solarPowerRequirement;
    protected int crystalRequirement;
    protected int buildTime;
    protected float sightRange;
    protected Animator anim;
    protected NavMeshAgent navMeshAgent;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

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
        Debug.Log("AA");
    }
}