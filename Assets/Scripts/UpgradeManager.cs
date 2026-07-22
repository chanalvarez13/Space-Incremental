using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour
{
    private PlanetManager targetPlanet;
    public void SelectPlanet(PlanetManager planet)
    {
        targetPlanet = planet;
        Debug.Log($"{planet.name} has been selected.");
    }
    public void Upgrade(PlanetUpgrade planetUpgrade)
    {
        if (targetPlanet.Energy >= planetUpgrade.currentCost)
        {
            targetPlanet.currentEnergyProduction += planetUpgrade.upgradeData.energyProductionIncrease;
            targetPlanet.currentPopulationInflux += planetUpgrade.upgradeData.populationIncrease;
            planetUpgrade.upgradeLevel++;
            Debug.Log($"{planetUpgrade.upgradeData.upgradeName} is now level {planetUpgrade.upgradeLevel}");

            targetPlanet.Energy -= planetUpgrade.currentCost;

            planetUpgrade.currentCost *= 1.35f;

            Debug.Log($"{targetPlanet.name} has been upgraded.");
        }
        else
        {
            Debug.Log("Failed to Upgrade: Not enough Energy.");
        }
    }

}
