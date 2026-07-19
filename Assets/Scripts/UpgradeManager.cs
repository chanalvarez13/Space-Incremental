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
    public int Upgrade(UpgradeData upgrade, UpgradeButton upgradeButton)
    {
        if (targetPlanet.Energy >= upgradeButton.upgradePrice)
        {
            targetPlanet.currentEnergyProduction += upgrade.energyProductionIncrease;
            targetPlanet.currentPopulationInflux += upgrade.populationIncrease;

            targetPlanet.Energy = targetPlanet.Energy - upgradeButton.upgradePrice;
            Debug.Log($"{targetPlanet.name} has been upgraded.");
            return 1;
        }
        else
        {
            Debug.Log("Failed to Upgrade: Not enough Energy.");
            return 0;
        }
    }
}
