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
        Debug.Log($"{upgrade.upgradeData.upgradeName} | Planet Cost: {upgrade.currentCost} | Base Cost: {upgrade.upgradeData.baseCost}");
    }

    public void UpdateButtonUI(PlanetUpgrade upgrade)
    {
        upgradeName.text = upgrade.upgradeData.upgradeName;
        upgradeCost.text = Mathf.RoundToInt(upgrade.currentCost).ToString();
    }
    public void PressUpgrade()
    {
        uManager.Upgrade(currentUpgrade);

        UpdateButtonUI(currentUpgrade);
    }
}
