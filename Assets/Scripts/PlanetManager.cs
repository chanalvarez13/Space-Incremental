using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    [SerializeField] private PlanetData planet;
    private UIManager uiManager;
    private UpgradeManager upgradeManager;
    [SerializeField] private List<PlanetUpgrade> upgradeTemplate;
    public List<PlanetUpgrade> upgrades = new List<PlanetUpgrade>();
    public string planetDescription;
    public float baseEnergyProduction = 1;
    public float currentEnergyProduction;
    public float Energy;
    public float Population;
    public float energyUpgradesBought;
    public float currentPopulationInflux;

    void Start()
    {
        uiManager = FindAnyObjectByType<UIManager>();
        upgradeManager = FindAnyObjectByType<UpgradeManager>();

        upgrades = CreateUpgrades(upgradeTemplate);
        AddProduction();
    }
    public void AddProduction()
    {
        currentEnergyProduction = baseEnergyProduction + energyUpgradesBought;
    }
    void Update()
    {
        Energy += currentEnergyProduction * Time.deltaTime;
        Population += currentPopulationInflux * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        uiManager.OnPlanetPress(this);
        upgradeManager.SelectPlanet(this);
        uiManager.ShowPlanetUpgrades(this);
        Debug.Log($"{planet.name} has been clicked!");
    }

    private List<PlanetUpgrade> CreateUpgrades(List<PlanetUpgrade> template)
    {
        List<PlanetUpgrade> newList = new List<PlanetUpgrade>();

        foreach (PlanetUpgrade upgrade in template)
        {
            newList.Add(new PlanetUpgrade
            {
                upgradeData = upgrade.upgradeData,
                upgradeLevel = 0,
                currentCost = upgrade.upgradeData.baseCost,
            });
        }
        return newList;
    }
}
