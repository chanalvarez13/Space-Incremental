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
    }
    public void Upgrade(PlanetUpgrade planetUpgrade)
    {
        switch (planetUpgrade.upgradeData.costType)
        {
            case UpgradeData.CostType.Energy:
                if (targetPlanet.Energy < planetUpgrade.currentCost)
                {
                    Debug.Log("You do not have enough Energy.");
                    return;
                }
                targetPlanet.Energy -= planetUpgrade.currentCost;
                break;
            case UpgradeData.CostType.Population:
                if (targetPlanet.Population < planetUpgrade.currentCost)
                {
                    Debug.Log("You do not have enough Population.");
                    return;
                }
                targetPlanet.Population -= planetUpgrade.currentCost;
                break;
        }

        targetPlanet.currentEnergyProduction += planetUpgrade.upgradeData.energyProductionIncrease;
        targetPlanet.currentPopulationInflux += planetUpgrade.upgradeData.populationIncrease;

        planetUpgrade.upgradeLevel++;
        planetUpgrade.currentCost *= planetUpgrade.upgradeData.costMultiplier;

        Debug.Log($"{planetUpgrade.upgradeData.upgradeName} now costs {planetUpgrade.currentCost}");
    }

}
