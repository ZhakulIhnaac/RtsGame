using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    GameObject currentActivePage;
    GameObject mainMenu;
    GameObject loadMenu;
    GameObject optionsMenu;

    private void Start()
    {
        mainMenu = GameObject.Find("MainMenu");
        loadMenu = GameObject.Find("LoadMenu");
        optionsMenu = GameObject.Find("OptionsMenu");
        loadMenu.SetActive(false);
        optionsMenu.SetActive(false);
        currentActivePage = mainMenu;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("NewGame", LoadSceneMode.Single);
    }

    public void changeMenu(GameObject menuToLoad)
    {
        currentActivePage.SetActive(false);
        currentActivePage = menuToLoad;
        currentActivePage.SetActive(true);
    }

    public void Load()
    {
        SceneManager.LoadScene("NewGame", LoadSceneMode.Single);
    }

    public void Exit()
    {

    }

}
