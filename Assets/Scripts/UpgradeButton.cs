using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public UpgradeData upgradeData;
    public UpgradeManager uManager;
    public PlanetManager planet;
    public Text upgradeCost;
    public void PressUpgrade()
    {
        uManager.Upgrade(upgradeData);
        UpdateEnergyButtonCost(upgradeData);
    }

    public void UpdateEnergyButtonCost(UpgradeData upgradeData)
    {
        upgradeCost.text = Mathf.RoundToInt(upgradeData.energyCost).ToString();
    }
}
