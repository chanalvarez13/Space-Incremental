using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PlanetUIMenu;

    public void OnPlanetPress()
    {
        PlanetUIMenu.SetActive(!PlanetUIMenu.activeSelf);
    }
}
