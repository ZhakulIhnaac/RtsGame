using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    protected int ownedCrystals;
    protected int solarPower;
    protected int population;
    protected string playerName;
    public Text populationCount;
    public Text crystalCount;
    public Text solarPowerCount;

    // Start is called before the first frame update
    void Start()
    {
        populationCount.text = "Population: " + "23" + "200"; //TODO: Player'ın oyundaki unitlerinden sayılacak.
        crystalCount.text = "Crystals: " + "200"; //TODO: Her kristal toplamada arttırılacak.
        solarPowerCount.text = "SolarPower: " + "300"; //TODO: Her güneş enerjisi toplamada arttırılacak.
    }

    // Update is called once per frame
    void Update()
    {

    }

    protected void KillPlayableObject()
    {
        Destroy(this);
    }
}
