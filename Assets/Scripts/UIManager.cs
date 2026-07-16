using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject PlanetUIMenu;
    public PlanetManager planetTarget;
    public Text planetName;
    public Text planetDescription;
    public Text energy;
    public Text population;
    public Text energyProduction;
    public Text populationIncrease;

    public void OnPlanetPress(PlanetManager targetPlanet)
    {
        planetTarget = targetPlanet;
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
            planetName.text = planetTarget.name;
            planetDescription.text = planetTarget.planetDescription;
            energy.text = planetTarget.Energy.ToString() + " Energy";
            population.text = planetTarget.Population.ToString() + " Population";
        }
    }
}
