using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public UpgradeManager uManager;
    public PlanetManager planet;
    public PlanetUpgrade currentUpgrade;
    public Text upgradeName;
    public Text upgradeCost;


    public void SetUpgrade(PlanetUpgrade upgrade)
    {
        currentUpgrade = upgrade;
        UpdateButtonUI(currentUpgrade);
    }

    public void UpdateButtonUI(PlanetUpgrade upgrade)
    {
            upgradeName.text = upgrade.upgradeData.upgradeName;
        if (upgrade.upgradeData.costType == UpgradeData.CostType.Energy)
        {
            upgradeCost.text = NumberFormatter.Format(upgrade.currentCost) + " E";
        } else if (upgrade.upgradeData.costType == UpgradeData.CostType.Population)
        {
            upgradeCost.text = NumberFormatter.Format(upgrade.currentCost) + " P";
        }

    }
    public void PressUpgrade()
    {
        uManager.Upgrade(currentUpgrade);

        UpdateButtonUI(currentUpgrade);
    }
}
