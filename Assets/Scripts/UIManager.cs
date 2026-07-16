using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject infoMenu;

    public void OnPlanetPress()
    {
        infoMenu.SetActive(true);
    }
    public void OnBackgroundPress()
    {
        infoMenu.SetActive(false);
    }
}
