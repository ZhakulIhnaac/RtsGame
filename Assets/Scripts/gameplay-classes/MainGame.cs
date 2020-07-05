using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public List<GameObject> selectedPlayableList;
    public Vector3 selectboxClickPos;
    public Vector3 selectboxReleasePos;
    public GameObject buildingToPlace;
    public int populationLimit;

    // UI Implementations
    public UnityEngine.UI.Button button_1;
    public UnityEngine.UI.Button button_2;
    public UnityEngine.UI.Button button_3;
    public UnityEngine.UI.Button button_4;
    public UnityEngine.UI.Button button_5;
    public UnityEngine.UI.Button button_6;
    public UnityEngine.UI.Button button_7;
    public UnityEngine.UI.Button button_8;
    public UnityEngine.UI.Button button_9;
    public UnityEngine.UI.Button button_10;
    public UnityEngine.UI.Button button_11;
    public UnityEngine.UI.Button button_12;

    void Start()
    {
        selectedPlayableList = new List<GameObject>();
        populationLimit = 200;
    }

    void Update() // TODO: Burası temizlenerek raycast vb işler objelerin metotlarının içine alınacak.
    {
        
    }

    void GiveWarningOnScreen(string warning)
    {
        // TODO: Oyuna yarı alanı ekle ve getirilen warning'i oraya yaz.
    }
}
