using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    protected int ownedCrystals;
    protected int solarPower;
    protected int population;
    protected string playerName;
    public int populationCount;
    public Text populationCountText;
    public Text crystalCountText;
    public Text solarPowerCountText;

    // Start is called before the first frame update
    void Start()
    {
        populationCountText.text = "Population: " + "23" + "200"; //TODO: Player'ın oyundaki unitlerinden sayılacak.
        crystalCountText.text = "Crystals: " + "200"; //TODO: Her kristal toplamada arttırılacak.
        solarPowerCountText.text = "SolarPower: " + "300"; //TODO: Her güneş enerjisi toplamada arttırılacak.
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
