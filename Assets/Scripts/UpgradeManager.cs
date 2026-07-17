using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public UpgradeData upgrade;
    private PlanetManager targetPlanet;


    void Start()
    {
    }

    public void Upgrade()
    {
        Debug.Log("Energy Increased");
    }
    public void PlanetPressedUpgrade(PlanetManager planet)
    {
        targetPlanet = planet;
        if (targetPlanet != null)
        {
            Debug.Log($"Upgrade target: {targetPlanet.name}");

            targetPlanet.currentEnergyProduction += upgrade.energyProductionIncrease;
        }

    }
}
