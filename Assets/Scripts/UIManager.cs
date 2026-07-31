using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject CanvasUIMenu;
    public GameObject PlanetUIMenu;
    public GameObject PlanetUpgradeMenu;
    public GameObject PlanetOwnedInformation;
    public GameObject PlanetNotOwned;
    public PlanetManager planetTarget;
    [SerializeField] public UpgradeButton[] upgradeButtons;
    public Text planetName;
    public Text planetDescription;
    public Text energy;
    public Text population;
    public Text currentEnergyProduction;
    public Text populationIncrease;

    public void OnPlanetPress(PlanetManager targetPlanet)
    {
        planetTarget = targetPlanet;
        if (CanvasUIMenu != null)
        {
            CanvasUIMenu.SetActive(!CanvasUIMenu.activeSelf);
            if (PlanetUIMenu != null)
            {
                PlanetUIMenu.SetActive(true);
            }

            if (PlanetUpgradeMenu != null && planetTarget.PlanetOwned == true)
            {
                PlanetNotOwned.SetActive(false);
                PlanetOwnedInformation.SetActive(true);
                PlanetUpgradeMenu.SetActive(true);
                ShowPlanetUpgrades(targetPlanet);
            } else if (PlanetUpgradeMenu != null && planetTarget.PlanetOwned == false)
            {
                PlanetOwnedInformation.SetActive(false);
                PlanetNotOwned.SetActive(true);
                PlanetUpgradeMenu.SetActive(false);
                Debug.Log("Planet is not owned.");
            }
        }
    }

    public void ShowPlanetUpgrades(PlanetManager planet)
    {
        for (int i = 0; i < planet.upgrades.Count; i++)
        {
            upgradeButtons[i].SetUpgrade(planet.upgrades[i]);
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
