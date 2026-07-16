using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject PlanetUIMenu;
    public PlanetManager planetTarget;
    public Text energy;
    public Text population;

    public void OnPlanetPress()
    {
        if (PlanetUIMenu != null)
        {
            PlanetUIMenu.SetActive(!PlanetUIMenu.activeSelf);
        }
    }

    void Start()
    {

    }

    public void Update()
    {
        if (planetTarget != null)
        {
            energy.text = planetTarget.Energy.ToString() + " Energy";
            population.text = planetTarget.Population.ToString() + " Population";
        }
        else if (planetTarget == null)
        {
            Debug.Log("There is no target planet.");
        }
    }
}
