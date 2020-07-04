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
    public float armor;
    protected int solarPowerRequirement;
    protected int crystalRequirement;
    protected int buildTime;
    protected float sightRange;
    protected Animator anim;
    protected NavMeshAgent navMeshAgent;
    [SerializeField] public Button button_1;
    [SerializeField] public Button button_3;
    [SerializeField] public Button button_2;
    [SerializeField] public Button button_4;
    [SerializeField] public Button button_5;
    [SerializeField] public Button button_6;
    [SerializeField] public Button button_7;
    [SerializeField] public Button button_8;
    [SerializeField] public Button button_9;
    [SerializeField] public Button button_10;
    [SerializeField] public Button button_11;
    [SerializeField] public Button button_12;

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
        Debug.Log("HElle");
    }
}