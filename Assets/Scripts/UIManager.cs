using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject PlanetUIMenu;

    public void OnPlanetPress()
    {
        if (PlanetUIMenu != null)
        {
            PlanetUIMenu.SetActive(!PlanetUIMenu.activeSelf);
        }
    }
}
