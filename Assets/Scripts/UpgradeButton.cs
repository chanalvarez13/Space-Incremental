using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public UpgradeData upgradeData;
    public UpgradeManager uManager;
    public PlanetManager planet;
    public Text upgradeCost;
    [SerializeField] public float upgradePrice;
    public void PressUpgrade()
    {
        int upgradeResponse = uManager.Upgrade(upgradeData,this);
        if (upgradeResponse == 1)
        {
            IncreaseUpgradePrice(upgradeData);
            UpdateEnergyButtonCost(upgradeData);
        }

    }

    public void UpdateEnergyButtonCost(UpgradeData upgradeData)
    {
        upgradeCost.text = Mathf.RoundToInt(upgradePrice).ToString();
    }

    public void IncreaseUpgradePrice(UpgradeData upgrade)
    {
        float upgradeCostMultiplier = 1.35f;
        upgradePrice = upgradePrice * upgradeCostMultiplier;
        Debug.Log($"The price of {upgrade.name} has been increased to {upgradePrice}");
    }
}
