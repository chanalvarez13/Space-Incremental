using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    private PlanetManager targetPlanet;
    public void SelectPlanet(PlanetManager planet)
    {
        targetPlanet = planet;
        Debug.Log($"{planet.name} has been selected.");
    }
    public void Upgrade(UpgradeData upgrade)
    {
        targetPlanet.currentEnergyProduction += upgrade.energyProductionIncrease;
        targetPlanet.currentPopulationInflux += upgrade.populationIncrease;
        Debug.Log($"{targetPlanet.name} has been upgraded.");
        Debug.Log($"Energy Production increased by {upgrade.energyProductionIncrease}");
        Debug.Log($"Population Influx increased by {upgrade.populationIncrease}");
    }
}
