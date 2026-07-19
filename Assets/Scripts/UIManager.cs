using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject PlanetUIMenu;
    public PlanetManager planetTarget;
    public UpgradeData UpgradeData;
    public Text planetName;
    public Text planetDescription;
    public Text energy;
    public Text population;
    public Text currentEnergyProduction;
    public Text populationIncrease;

    public void OnPlanetPress(PlanetManager targetPlanet)
    {
        planetTarget = targetPlanet;
        if (PlanetUIMenu != null)
        {
            UpgradeButton.UpdateEnergyButtonCost(UpgradeData);
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
            currentEnergyProduction.text = planetTarget.currentEnergyProduction.ToString() + "/s";
            populationIncrease.text = planetTarget.currentPopulationInflux.ToString() + "/s";
            energy.text = Mathf.RoundToInt(planetTarget.Energy) + " Energy";
            population.text = Mathf.RoundToInt(planetTarget.Population) + " Population";
        }
    }
}
